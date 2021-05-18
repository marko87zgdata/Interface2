using System;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer("Pro15", "HP", "Win10");
            Desktop stolno = new Desktop("AX", "Intel", "Win7", 55.5);
            Laptop prijenosno = new Laptop("VX", "Dell", "Win XP", 3600, 3.45);

            Console.WriteLine(comp.ToString());
            Console.WriteLine(stolno.ToString());
            Console.WriteLine(prijenosno.ToString());

        }
    }
}
