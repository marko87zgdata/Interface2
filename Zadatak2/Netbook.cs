using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    sealed class Netbook : Laptop
    {
        public Netbook(string model, string manufacturer, string opSystem, int batCap, double weight) 
            : base(model, manufacturer, opSystem, batCap, weight)
        {

        }

        public override string GetCompType()
        {
            return "netbook laptop computer";
        }

        public override double CalcPort()
        {
            return 1;
        }
    }
}
