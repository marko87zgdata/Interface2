using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class TextBook: Book, IDepozit, ILokacija
    {
        public string Subject { get; set; }

        public TextBook(int id, string name, string author, string polica, string red,string subject)
            :base(id, name, author, polica, red)
        {
            Subject = subject;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za školske udžbenike je 14 dana.";
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
            return $"Lokacija udžbenika je red broj {Red} na polici broj {Polica}";
        }
    }
}
