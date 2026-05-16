using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class DataBase
    {
        private List<Employee> employees = new List<Employee>();
        private List<Payroll> payrolls = new List<Payroll>();

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public void AddManager(Manager man)
        {
            employees.Add(man);
        }
        public void AddPayroll(Payroll pr)
        {
            payrolls.Add(pr);
        }
        public void GetPayrollReport()
        {
            Console.WriteLine("Maaş Hesabatı");
            foreach (Payroll p in payrolls)
            {
                Console.WriteLine($"İşçi Id: {p.GetEmployeeId()} | Net Maaş: {p.GetNetSalary()} AZN | Tarix: {p.GetCreatedDate()}");
            }
        }
        public void GetAll()
        {
            foreach (Employee isci in employees)
            {
                Console.WriteLine(isci.GetInfo());
            }
        }

        public Employee FindEmployeeById(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.GetId() == id)
                {
                    return emp; 
                }
            }
            return null;
        }
        public void RemoveEmployeeById(int id)
        {
            Employee found = null;
            foreach (Employee emp in employees)
            {
                if (emp.GetId() == id)
                {
                    found = emp;
                    break; 
                }
            }

            if (found != null)
            {
                employees.Remove(found);
                Console.WriteLine($"Sistemdən silindi: {found.GetFullName()}");
            }
            else
            {
                Console.WriteLine($"Xəta: ID-si {id} olan işçi tapılmadı!");
            }
        }
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public int GetEmployeeCount()
        {
            return employees.Count;
        }
    }
}