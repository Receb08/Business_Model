using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase();

            Developer dev = new Developer();
            dev.SetId(1);
            dev.SetFullName("Vəli Əliyev");
            dev.SetPosition("Developer");
            dev.SetBaseSalary(1500);
            dev.AddTech("C#");
            dev.AddTech("Java");
            dev.AddTech("Python");
            db.AddEmployee(dev);

            Manager man = new Manager();
            man.SetId(2);
            man.SetFullName("Leyla Həsənova");
            man.SetPosition("Manager");
            man.SetBaseSalary(2000);
            man.SetTeamSize(5);
            man.SetDepartment("IT");
            db.AddManager(man);

            EmployeeTask task1 = new EmployeeTask("Backend", "Baza qurulması", new DateTime(2026, 05, 10));
            task1.CompleteTask(new DateTime(2026, 05, 12));

            Payroll p1 = new Payroll();
            p1.SetId(101);
            p1.SetEmployeeId(dev.GetId());
            p1.Calculate(dev, task1);
            db.AddPayroll(p1);
            db.GetAll();
            db.GetPayrollReport();

            int umumiSay = db.GetEmployeeCount();
            Console.WriteLine($"Sistemdəki ümumi işçi sayısı: {umumiSay}");

            Console.WriteLine("ID-si 2 olan işçi axtarılır");
            Employee tapilanIsci = db.FindEmployeeById(2);
            if (tapilanIsci != null)
            {
                Console.WriteLine($"TAPILDI: {tapilanIsci.GetFullName()} -> Vəzifəsi: {tapilanIsci.GetPosition()}");
            }
            else
            {
                Console.WriteLine("XƏTA: Bu ID-də işçi tapılmadı.");
            }

            Console.WriteLine("ID-si 1 olan işçi (Vəli) sistemdən silinir");
            db.RemoveEmployeeById(1);

            Console.WriteLine($"Silinmədən sonra qalan ümumi işçi sayısı: {db.GetEmployeeCount()}");
        }
    }
}
