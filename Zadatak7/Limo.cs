using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    class Limo: Vehicle
    {
        public double Length { get; set; }
        public int NoOfSeats { get; set; }
        public bool SunRoof { get; set; }

        public Limo(string regNo, string model, double length, int noOfSeats, bool sunRoof)
            : base(regNo, model)
        {
            Length = length;
            NoOfSeats = noOfSeats;
            SunRoof = sunRoof;
        }

        public override string ToString()
        {
            return $"RegNo: {RegNo}, Model: {Model}, Length: {Length}, NoOfSeats: {NoOfSeats} SunRoof: {SunRoof}";
        }

        public override double GetMaxPassengers()
        {
            Console.Write("Broj sjedala u limuzini: ");
            return NoOfSeats;
        }
    }
}
