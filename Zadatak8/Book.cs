using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class Book: LibraryItem
    {
        public string Author { get; set; }


        public Book(int id, string name, string author)
            : base(id, name)
        {
            Author = author;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za knjige je 14 dana.";
        }

        
    }
}
