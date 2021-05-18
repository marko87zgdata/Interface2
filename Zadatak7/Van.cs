using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    abstract class Van: Vehicle
    {
        public double Height { get; set; }

        public Van(string regNo, string model, double height)
            : base(regNo, model)
        {
            Height = height;
        }

        public override string ToString()
        {
            return "Height: " + Height;
        }
    }
}
