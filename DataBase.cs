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
        private List<EmployeeTask> allTasks = new List<EmployeeTask>();

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
                Console.WriteLine($"İşçi Id: {p.GetEmployeeId()}, Net Maaş: {p.GetNetSalary()} AZN, Tarix: {p.GetCreatedDate()}");
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
                if (emp.GetId() == id) return emp;
            }
            return null;
        }

        public void RemoveEmployeeById(int id)
        {
            Employee found = null;
            foreach (Employee emp in employees)
            {
                if (emp.GetId() == id) { found = emp; break; }
            }
            if (found != null)
            {
                employees.Remove(found);
                Console.WriteLine($"Sistemdən silindi: {found.GetFullName()}");
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
        public void CreateTask(EmployeeTask task)
        {
            allTasks.Add(task);
            Console.WriteLine($" Yeni Tapşırıq Yaradıldı: {task.GetTitle()} ID: {task.GetId()}");
        }

        public void AssignTaskToEmployee(int taskId, int employeeId)
        {
            EmployeeTask foundTask = null;
            foreach (EmployeeTask t in allTasks)
            {
                if (t.GetId() == taskId) { foundTask = t; break; }
            }

            Employee foundEmp = FindEmployeeById(employeeId);

            if (foundTask != null && foundEmp != null)
            {
                foundTask.SetEmployee(foundEmp);
                foundEmp.AddTaskToEmployee(foundTask);
                Console.WriteLine($"Uğurlu: '{foundTask.GetTitle()}' tapşırığı '{foundEmp.GetFullName()}' adlı işçiyə təyin olundu.");
            }
            else
            {
                Console.WriteLine("Xəta: Tapşırıq və ya İşçi tapılmadı!");
            }
        }

        public void RemoveTaskById(int id)
        {
            EmployeeTask found = null;
            foreach (EmployeeTask t in allTasks)
            {
                if (t.GetId() == id) { found = t; break; }
            }
            if (found != null)
            {
                allTasks.Remove(found);
                Console.WriteLine($"Tapşırıq sistemdən silindi: {found.GetTitle()}");
            }
        }
    }
}
