using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class Developer : Employee
    {
        private List<string> Technologies = new List<string>();

        public void AddTech(string tech)
        {
            Technologies.Add(tech);
        }

        public List<string> GetTechnologies()
        {
            return Technologies;
        }

        public override double CalculateBonus()
        {
            return Technologies.Count * 100;
        }

        public override string GetInfo()
        {
            string techs = string.Join(", ", Technologies);
            return base.GetInfo() + $", Texnologiyalar: {techs}";
        }
    }
}
