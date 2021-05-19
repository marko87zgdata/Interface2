using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Laptop: Computer, IPrenosivi
    {
        public int BatCap { get; set; }
        public double Weight { get; set; }

        public Laptop(string model, string manufacturer, string opSystem, int batCap, double weight)
            : base(model, manufacturer, opSystem)
        {
            BatCap = batCap;
            Weight = weight;
        }

        public override string GetCompType()
        {
            return "laptop computer";
        }

        public override double CalcPort()
        {
            return Weight;
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
