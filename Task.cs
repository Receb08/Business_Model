using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
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

        public void SetStatus(string status)
        {
            this.status = status;
        }

        public void CompleteTask(DateTime completionDate)
        {
            this.actualCompletionDate = completionDate;
            this.status = "Completed";
        }
    }
}
