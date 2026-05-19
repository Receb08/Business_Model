using Biznes_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmployeeTask
{
    private int id;
    private string title;
    private string description;
    private DateTime deadline;
    private DateTime actualCompletionDate;
    private string status;
    private Employee emp; 
    public EmployeeTask(int id, string title, string description, string deadlineString)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.deadline = DateTime.Parse(deadlineString);
        this.status = "InProgress";
    }

    public int GetId() { return id; }
    public string GetTitle() { return title; }
    public DateTime GetDeadline() { return deadline; }
    public DateTime GetActualCompletionDate() { return actualCompletionDate; }
    public string GetStatus() { return status; }

    public Employee GetEmployee() { return emp; }
    public void SetEmployee(Employee employee) { this.emp = employee; }
    public void SetStatus(string status) { this.status = status; }

    public void CompleteTask(string completionDateString)
    {
        this.actualCompletionDate = DateTime.Parse(completionDateString);
        this.status = "Completed";
    }
}
