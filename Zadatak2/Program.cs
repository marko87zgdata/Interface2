using System;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Desktop stolno = new Desktop("AX", "Intel", "Win7", 55.5);
            Laptop prijenosno = new Laptop("VX", "Dell", "Win XP", 3600, 3.45);

            Console.WriteLine("Stolno je: " + stolno.GetCompType() + ",");
            Console.WriteLine("a njegova težina je: " + stolno.CalcPort() + "kg");

            Console.WriteLine('\n');
            Console.WriteLine("Prijenosno je: " + prijenosno.GetCompType() + ",");
            Console.WriteLine("a njegova težina je: " + prijenosno.CalcPort() + "kg");

            //Zadatak3

            Netbook netb = new Netbook("CX", "Acer", "Linux", 1800, 1.65);

            Console.WriteLine('\n');
            Console.WriteLine("Prijenosno je: " + netb.GetCompType() + ",");
            Console.WriteLine("a njegova težina je: " + netb.CalcPort() + "kg");
        }
    }
}
