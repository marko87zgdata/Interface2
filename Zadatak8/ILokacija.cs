using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    interface ILokacija
    {
        public string Polica { get; set; }
        public string Red { get; set; }

        public string GetLocation();
    }
}
