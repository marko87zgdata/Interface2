using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    class Car: Vehicle
    {
        public string CarType { get; set; }
        public int NoOfSeats { get; set; }
        public double CargoSpace { get; set; }

        public Car(string regNo, string model, string carType, int noOfSeats, double cargoSpace)
            :base (regNo, model)
        {
            CarType = carType;
            NoOfSeats = noOfSeats;
            CargoSpace = cargoSpace;
        }

        public override string ToString()
        {
            return "CarType: " + CarType + ", NoOfSeats: " + NoOfSeats + ", CargoSpace: " + CargoSpace;
        }

        public override double GetMaxPassengers()
        {
            Console.WriteLine("Teret u gepeku automobila: " + CargoSpace);
            Console.Write("Broj sjedala: ");
            return NoOfSeats;

        }

        
    }
}
