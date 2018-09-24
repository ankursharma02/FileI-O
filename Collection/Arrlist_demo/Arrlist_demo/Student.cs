using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrlist_demo
{
    class Student:IComparable<Student>
    {
        public int Sid { get; set; }
        public string name { get; set; }
        public int Class{ get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;

        }
    }
    class CompareStudent : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;

        }
    }

    class TestStudent
    {
        //public static int CompareNames(Student s1, Student s2)
        //{
        //    return s1.name.CompareTo(s2.name);
        //}
        public static void Main()
        {
            Student s1 = new Student { Sid = 101, name = "ank", Class = 10, Marks = 93.23f };
            Student s2 = new Student { Sid = 103, name = "ssd", Class = 10, Marks = 90.23f };
            Student s3 = new Student { Sid = 104, name = "def", Class = 11, Marks = 91.23f };
            Student s4 = new Student { Sid = 106, name = "fmt", Class = 12, Marks = 60.23f };
            Student s6 = new Student { Sid = 102, name = "gef", Class = 11, Marks = 71.23f };
            Student s5 = new Student { Sid = 105, name = "hmt", Class = 12, Marks = 80.23f };
            List<Student> Students = new List<Student>() { s1, s2, s3, s4,s5,s6 };
           Students.Sort();
            Students.Reverse();
            foreach (Student s in Students)
             Console.WriteLine(s.Sid + " " + s.name + " " + s.Class + " " + s.Marks);

            CompareStudent obj = new CompareStudent();
            Students.Sort(obj);
            Console.WriteLine("\n====Sort based on marks======");
            foreach (Student s in Students)
                Console.WriteLine(s.Sid + " " + s.name + " " + s.Class + " " + s.Marks);


            //   Comparison<Student> obj1 = new Comparison<Student>(CompareNames);

            //  Students.Sort(delegate(Student S1,Student S2) { return S1.name.CompareTo(S2.name); });
            Students.Sort((S1, S2) =>S1.name.CompareTo(S2.name)); 
            Console.WriteLine("\n====Sort based on names========");
            foreach (Student s in Students)
                Console.WriteLine(s.Sid + " " + s.name + " " + s.Class + " " + s.Marks);

            Console.ReadLine();
        }
    }
}
