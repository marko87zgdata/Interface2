using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Computer
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string OpSystem { get; set; }

        public Computer(string model, string manufacturer, string opSystem)
        {
            Model = model;
            Manufacturer = manufacturer;
            OpSystem = opSystem;
        }

        public override string ToString()
        {
            return "Model: " + Model + ", Manu: " + Manufacturer + ", OS: " + OpSystem;
        }
    }
}
