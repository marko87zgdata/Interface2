using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class Dictionary: Book, ILokacija
    {
        public string FirstLanguage { get; set; }
        public string SecondLanguage { get; set; }

        public Dictionary(int id, string name, string author, string polica, string red, string firstLanguage, string secondLanguage)
            : base(id, name, author, polica, red)
        {
            FirstLanguage = firstLanguage;
            SecondLanguage = secondLanguage;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za rječnike je 14 dana.";
        }

        public string GetLocation()
        {
            return $"Lokacija rječnika je red broj {Red} na polici broj {Polica}";
        }
    }
}
