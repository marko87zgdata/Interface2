using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name;
        }

        public abstract double GetGrade();

        public abstract bool IsOutstanding();
    }
}
