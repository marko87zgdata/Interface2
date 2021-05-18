using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Desktop: Computer
    {
        public double Height { get; set; }

        public Desktop(string model, string manufacturer, string opSystem, double height)
            :base(model, manufacturer, opSystem)
        {
            Height = height;
        }

        public override string ToString()
        {
            return "Model: " + Model + ", Manu: " + Manufacturer + ", OS: " + OpSystem + ", Height: " + Height + "cm";
        }
    }
}
