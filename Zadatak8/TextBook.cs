using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class TextBook: Book
    {
        public string Subject { get; set; }

        public TextBook(int id, string name, string author, string subject)
            :base(id, name, author)
        {
            Subject = subject;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za školske udžbenike je 14 dana.";
        }
    }
}
