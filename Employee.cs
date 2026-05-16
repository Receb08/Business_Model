using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class Employee: BaseModel
    {
        private string FullName;
        private string Position;
        private double BaseSalary;

        public string GetFullName() { return FullName; }

        public string GetPosition() { return Position; }

        public double GetBaseSalary() { return BaseSalary; }
        public void SetFullName(string name) { FullName = name; }
        public void SetPosition(string pos) { Position = pos; }
        public void SetBaseSalary(double salary) { BaseSalary = salary; }
        public virtual string GetInfo()
        {
            double bonus = CalculateBonus();
            double baseSalary = GetBaseSalary();
            double tax = (baseSalary + bonus) * 0.14;
            double netSalary = (baseSalary + bonus) - tax; 
            return $"Id: {GetId()}, Name: {GetFullName()}, Position: {GetPosition()}, Net Salary: {netSalary} AZN";
        }

        public virtual double CalculateBonus()
        {
            return 0;
        }
    }
}