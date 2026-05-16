using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class Manager : Employee
    {
        private int teamSize;
        private string department;

        public int GetTeamSize() { return teamSize; }
        public string GetDepartment() { return department; }

        public void SetTeamSize(int size) { this.teamSize = size; }
        public void SetDepartment(string dept) { this.department = dept; }

        public override double CalculateBonus()
        {
            return this.teamSize * 50.0; 
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $" Şöbə: {department}, Komanda Sayı: {teamSize}";
        }
    }
}