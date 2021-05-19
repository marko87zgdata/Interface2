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

            Mp3Player mp3 = new Mp3Player("Sony5", 560, 1024);

            Console.WriteLine('\n');
            Console.WriteLine("netbook:");
            netb.GetBatteryCapacity();
            netb.GetModel();

            Console.WriteLine('\n');
            Console.WriteLine("prijenosno:");
            prijenosno.GetBatteryCapacity();
            prijenosno.GetModel();

            Console.WriteLine('\n');
            Console.WriteLine("mp3 player:");
            mp3.GetBatteryCapacity();
            mp3.GetModel();
        }
    }
}
