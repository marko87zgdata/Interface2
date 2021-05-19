using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    abstract class Vehicle
    {
        public string RegNo { get; private set; }
        public string Model { get; private set; }
        
        public Vehicle(string regNo, string model)
        {
            RegNo = regNo;
            Model = model;
        }

        public override string ToString()
        {
            return "RegNo: " + RegNo + ", Model: " + Model;
        }

        public abstract double GetMaxPassengers();
    }
}
