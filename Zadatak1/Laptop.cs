using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Laptop: Computer
    {
        public int BatCap { get; set; }
        public double Weight { get; set; }

        public Laptop(string model, string manufacturer, string opSystem, int batCap, double weight)
            :base(model, manufacturer, opSystem)
        {
            BatCap = batCap;
            Weight = weight;
        }

        public override string ToString()
        {
            return "Model: " + Model + ", Manu: " + Manufacturer + ", OS: " + OpSystem + ", BatCap: " + BatCap + "mAh, Weight: " + Weight + "kg";
        }
    }
}
