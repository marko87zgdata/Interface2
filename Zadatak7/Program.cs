using System;

namespace Zadatak7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("ZG222NV", "Opel", "SUV", 5, 500);
            Limo limo = new Limo("DA333IG", "Dacia", 8.5, 8, true);
            PassengerVan passVan = new PassengerVan("ST345RG", "Fiat", 2.2, 9);
            CargoVan cargoVan = new CargoVan("DU678AA", "Mazda", 2.5, 5000);

            Console.WriteLine(car.ToString());
            Console.WriteLine(limo.ToString());
            Console.WriteLine(passVan.ToString());
            Console.WriteLine(cargoVan.ToString());
            Console.WriteLine('\n');
            Console.WriteLine(car.GetMaxPassengers());
            Console.WriteLine('\n');
            Console.WriteLine(limo.GetMaxPassengers());
            Console.WriteLine(passVan.GetMaxPassengers());
            Console.WriteLine(cargoVan.GetMaxPassengers());
        }
    }
}
