using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class Employee : BaseModel
    {
        private string fullName;
        private string position;
        private double baseSalary;

        private List<EmployeeTask> myTasks = new List<EmployeeTask>();

        public string GetFullName() { return fullName; }
        public string GetPosition() { return position; }
        public double GetBaseSalary() { return baseSalary; }

        public void SetFullName(string name) { fullName = name; }
        public void SetPosition(string pos) { position = pos; }
        public void SetBaseSalary(double salary) { baseSalary = salary; }

        public void AddTaskToEmployee(EmployeeTask task)
        {
            myTasks.Add(task);
        }

        public List<EmployeeTask> GetMyTasks()
        {
            return myTasks;
        }

        public virtual double CalculateBonus()
        {
            return 0.0;
        }

        public virtual string GetInfo()
        {
            return $"ID: {this.GetId()}, Ad: {fullName}, Vəzifə: {position}, Maaş: {baseSalary} AZN, Tapşırıq Sayı: {myTasks.Count}";
        }
    }
}
