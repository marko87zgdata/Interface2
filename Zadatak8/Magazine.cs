using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class Magazine: LibraryItem, ILokacija
    {
        public string ContentCategory { get; set; }
        public int Issue { get; set; }
        public string Polica { get; set; }
        public string Red { get; set; }

        public Magazine(int id, string name, string contentCategory, int issue, string polica, string red)
            :base (id, name)
        {
            ContentCategory = contentCategory;
            Issue = issue;
            Polica = polica;
            Red = red;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za časopise je 7 dana.";
        }

        public string GetLocation()
        {
            Console.Write("Lokacija časopisa je red broj " + Red + " na polici broj "); 
            return Polica;
        }
    }
}
