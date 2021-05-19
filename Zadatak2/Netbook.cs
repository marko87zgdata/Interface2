using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal sealed class Netbook : Laptop, IPrenosivi
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

        public void GetModel()
        {
            Console.WriteLine(Model);
        }

        public void GetBatteryCapacity()
        {
            Console.WriteLine(BatCap);
        }
    }
}
