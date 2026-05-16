using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class Developer : Employee
    {
        private List<string> techStack = new List<string>();

        public void AddTech(string tech)
        {
            techStack.Add(tech);
        }

        public override double CalculateBonus()
        {
            return 100.0;
        }

        public override string GetInfo()
        {
            string languages = string.Join(", ", techStack);
            return base.GetInfo() + $" Texnologiyalar: ({languages})";
        }
    }
}
