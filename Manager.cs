using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class Manager : Employee
    {
        private int TeamSize;
        private string Department;

        public int GetTeamSize() { return TeamSize; }
        public string GetDepartment() { return Department; }

        public void SetTeamSize(int size) { TeamSize = size; }
        public void SetDepartment(string dept) { Department = dept; }

        public override double CalculateBonus()
        {
            return TeamSize * 50;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" Departament: {Department}, Komanda Sayı: {TeamSize}";
        }
    }
}
