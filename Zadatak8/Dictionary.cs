using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class Dictionary: Book
    {
        public string FirstLanguage { get; set; }
        public string SecondLanguage { get; set; }

        public Dictionary(int id, string name, string author, string firstLanguage, string secondLanguage)
            : base(id, name, author)
        {
            FirstLanguage = firstLanguage;
            SecondLanguage = secondLanguage;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za rječnike je 14 dana.";
        }
    }
}
