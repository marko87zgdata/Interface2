using System;

namespace Zadatak8
{
    class Program
    {
        static void Main(string[] args)
        {
            Book knjiga = new Book(1122, "Fizika1", "Tin Ujević");
            Magazine casopis = new Magazine(2233, "Drvo Znanja", "Znanost", 3, "3", "4");
            DigitalItem dvd = new DigitalItem(3344, "Matematika-geometrija", "DVD");
            EItem stranica = new EItem(4455, "Wikipedia", "www.wikipedia.com");
            TextBook udzbenik = new TextBook(1233, "Pravopis", "Dobriša Cesarić", "Gramatika");
            Dictionary rjecnik = new Dictionary(1344, "HRV-ENG rječnik", "Bruce Lee", "Hrvatski", "Engleski");

            Console.WriteLine(knjiga.GetLoanPeriod());
            Console.WriteLine(casopis.GetLoanPeriod());
            Console.WriteLine(dvd.GetLoanPeriod());
            Console.WriteLine(stranica.GetLoanPeriod());
            Console.WriteLine(udzbenik.GetLoanPeriod());
            Console.WriteLine(rjecnik.GetLoanPeriod());

            LibraryItem[] items = new LibraryItem[] { knjiga, casopis, dvd, stranica, udzbenik, rjecnik };

            Console.WriteLine('\n');
            Console.WriteLine("Posuđeno:");
            foreach (var item in items)
            {
                if (item==dvd)
                {
                    Console.WriteLine(item.Id + " " + item.Name);
                    Console.WriteLine("Polog: " + dvd.GetCashDepozitAmount());
                }
                else
                Console.WriteLine(item.Id + " " + item.Name);
            }

            Console.WriteLine('\n');
            Console.WriteLine(casopis.GetLocation());
        }
    }
}
