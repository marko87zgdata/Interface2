using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    class Teacher : Person
    {
        public string Subject { get; set; }
        public double TeacherGrade { get; set; }

        public Teacher(int id, string name, string subject, double teacherGrade)
            : base(id, name)
        {
            Subject = subject;
            TeacherGrade = teacherGrade;
        }
        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name + ", Subject: " + Subject + ", TeacherGrade: " + TeacherGrade;
        }

        public override double GetGrade()
        {
            return TeacherGrade;
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
