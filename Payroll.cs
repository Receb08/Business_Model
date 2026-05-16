using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class Payroll : BaseModel
    {
        private int EmployeeId;
        private double Bonus;
        private double Penalty;
        private double Tax;
        private double NetSalary;

        public int GetEmployeeId() { return EmployeeId; }
        public double GetBonus() { return Bonus; }
        public double GetTax() { return Tax; }
        public double GetNetSalary() { return NetSalary; }
        public double GetPenalty() { return Penalty; }

        public void SetEmployeeId(int id) { EmployeeId = id; }
        public void SetBonus(double bonus) { Bonus = bonus; }
        public void SetTax(double tax) { Tax = tax; }
        public void SetNetSalary(double net) { NetSalary = net; }
        public void SetPenalty(double penalty) { Penalty = penalty; }

        public void Calculate(Employee emp, EmployeeTask task)
        {
            double baseSalary = emp.GetBaseSalary();
            double bonus = emp.CalculateBonus();
            double calculatedPenalty = 0;

            if (task.GetStatus() == "Completed")
            {
                if (task.GetActualCompletionDate() > task.GetDeadline())
                {
                    int delayDays = (task.GetActualCompletionDate() - task.GetDeadline()).Days;
                    calculatedPenalty = delayDays * (baseSalary * 0.01);
                }
            }
            else if (task.GetStatus() == "InProgress")
            {
                if (DateTime.Now > task.GetDeadline())
                {
                    int delayDays = (DateTime.Now - task.GetDeadline()).Days;
                    calculatedPenalty = delayDays * (baseSalary * 0.01);
                }
            }

            double tax = (baseSalary + bonus) * 0.14;
            double net = (baseSalary + bonus) - tax - calculatedPenalty;

            this.EmployeeId = emp.GetId();
            this.Bonus = bonus;
            this.Tax = tax;
            this.Penalty = calculatedPenalty;
            this.NetSalary = net;
            this.SetCreatedDate(DateTime.Now);

            Console.WriteLine($"Hesablama: {emp.GetFullName()} ({emp.GetPosition()})");
            Console.WriteLine($"Tapşırıq: {task.GetTitle()} -> Status: {task.GetStatus()}");
            Console.WriteLine($"Base: {baseSalary} AZN, Bonus: {bonus} AZN, Vergi: {tax} AZN, Gecikmə Cəriməsi: {calculatedPenalty} AZN");
            Console.WriteLine($"Yekun Nəticə: {net} AZN");
        }
    }
    public class EmployeeTask
    {
        private string title;
        private string description;
        private DateTime deadline;
        private DateTime actualCompletionDate;
        private string status;

        public EmployeeTask(string title, string description, DateTime deadline)
        {
            this.title = title;
            this.description = description;
            this.deadline = deadline;
            this.status = "InProgress";
        }

        public string GetTitle() { return title; }
        public DateTime GetDeadline() { return deadline; }
        public string GetStatus() { return status; }
        public DateTime GetActualCompletionDate() { return actualCompletionDate; }

        public void SetStatus(string status) { this.status = status; }

        public void CompleteTask(DateTime completionDate)
        {
            this.actualCompletionDate = completionDate;
            this.status = "Completed";
        }
    }
}