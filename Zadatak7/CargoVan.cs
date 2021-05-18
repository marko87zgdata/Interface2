using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    class CargoVan: Van
    {
        private double MaxSpace { get; set; }

        public CargoVan(string regNo, string model, double height, double maxSpace)
            : base(regNo, model, height)
        {
            MaxSpace = maxSpace;
        }

        public override string ToString()
        {
            return "Height: " + Height + ", MaxSpace: " + MaxSpace;
        }

        public override double GetMaxPassengers()
        {
            Console.Write("Max teret u teretnom kombiju: ");
            return MaxSpace;
        }
    }
}
