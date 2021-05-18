using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    abstract class LibraryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public LibraryItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract string GetLoanPeriod();
    }
}
