using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    class Student : Person
    {
        public short AcademicYear { get; set; }
        public int[] Ocjene { get; set; }

        public Student(int id, string name, short academicYear)
            : base(id, name)
        {
            AcademicYear = academicYear;
            Ocjene = new int[5];
        }

        public override string ToString()
        {
            string povratniString = "Id: " + Id + ", Name: " + Name + ", Year: " + AcademicYear + ", Ocjene: ";
            foreach (var item in Ocjene)
            {
                povratniString += item + " ";
            }
            return povratniString;
        }

        public override double GetGrade()
        {
            int suma = 0;
            foreach (var item in Ocjene)
            {
                suma += item;
            }
            return (double)suma / Ocjene.Length;
        }

        public override bool IsOutstanding()
        {
            if (GetGrade() > 4.5)
            {
                return true;
            }
            else
                return false;
        }
    }
}
