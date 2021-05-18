using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class DigitalItem: LibraryItem, IDepozit
    {
        public string Type { get; set; }

        public DigitalItem(int id, string name, string type)
            :base (id, name)
        {
            Type = type;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za digitalne sadržaje je 30 dana.";
        }

        public bool HasCashDepozit()
        {
            return true;
        }

        public double GetCashDepozitAmount()
        {
            return 50.0;
        }
    }
}
