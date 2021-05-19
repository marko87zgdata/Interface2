using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class Book: LibraryItem, ILokacija
    {
        public string Author { get; set; }
        public string Polica { get; set; }
        public string Red { get; set; }


        public Book(int id, string name, string author, string polica, string red)
            : base(id, name)
        {
            Author = author;
            Polica = polica;
            Red = red;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za knjige je 14 dana.";
        }

        public string GetLocation()
        {
            return $"Lokacija knjige je red broj {Red} na polici broj {Polica}";
        }
    }
}
