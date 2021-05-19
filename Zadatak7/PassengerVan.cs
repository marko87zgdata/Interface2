using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    class PassengerVan: Van
    {
        private int NoOfPassenger { get; set; }

        public PassengerVan(string regNo, string model, double height, int noOfPasseneger) 
            : base(regNo, model, height)
        {
            NoOfPassenger = noOfPasseneger;
        }

        public override string ToString()
        {
            return $"RegNo: {RegNo}, Model: {Model}, Height: {Height}, NoOfPassenger: {NoOfPassenger}";
        }

        public override double GetMaxPassengers()
        {
            Console.Write("Broj sjedala u putničkom kombiju: ");
            return NoOfPassenger;
        }
    }
}
