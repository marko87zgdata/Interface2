using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    class EItem: LibraryItem
    {
        public string Url { get; set; }

        public EItem(int id, string name, string url)
            : base(id, name)
        {
            Url = url;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za e-sadržaje je 30 dana.";
        }
    }
}
