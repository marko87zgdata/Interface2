using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class DigitalItem: LibraryItem, IDepozit, ILokacija
    {
        public string Type { get; set; }
        public string Polica { get; set; }
        public string Red { get; set; }

        public DigitalItem(int id, string name, string polica, string red, string type)
            :base (id, name)
        {
            Type = type;
            Polica = polica;
            Red = red;
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

        public string GetLocation()
        {
            return $"Lokacija digitalnog medija je red broj {Red} na polici broj {Polica}";
        }
    }
}
