using Biznes_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        DataBase db = new DataBase();
        Developer dev = new Developer();
        dev.SetId(1);
        dev.SetFullName("Vəli Əliyev");
        dev.SetPosition("Developer");
        dev.SetBaseSalary(1500);
        dev.AddTech("C#");
        db.AddEmployee(dev);

        Manager man = new Manager();
        man.SetId(2);
        man.SetFullName("Leyla Həsənova");
        man.SetPosition("Manager");
        man.SetBaseSalary(2000);
        man.SetTeamSize(4);
        man.SetDepartment("IT");
        db.AddManager(man);

        EmployeeTask task1 = new EmployeeTask(501, "Backend", "Baza qurulması", "10.05.2026");
        db.CreateTask(task1);
        db.AssignTaskToEmployee(501, 1);

        Console.WriteLine("Bazadakı Mövcud İşçilərin Siyahısı:");
        db.GetAll();

        task1.CompleteTask("12.05.2026");

        Payroll p1 = new Payroll();
        p1.SetId(101);
        p1.SetEmployeeId(dev.GetId());
        p1.Calculate(dev, task1);
        db.AddPayroll(p1);
        db.RemoveTaskById(501);
        db.RemoveEmployeeById(2); 

        Console.WriteLine($"Son qalan ümumi işçi sayı: {db.GetEmployeeCount()}");

    }
}
