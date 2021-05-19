using System;

namespace Zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student(245, "Marko", 1);
            stud.Ocjene[0] = 4;
            stud.Ocjene[1] = 5;
            stud.Ocjene[2] = 5;
            stud.Ocjene[3] = 5;
            stud.Ocjene[4] = 4;



            Teacher prof = new Teacher(51, "Stipe", "Algebra", 4.1);

            Console.WriteLine(stud.ToString());
            Console.WriteLine(prof.ToString());

            Console.WriteLine(stud.GetGrade());
            Console.WriteLine(stud.IsOutstanding());

            Console.WriteLine(prof.GetGrade());
            Console.WriteLine(prof.IsOutstanding());
        }
    }
}
