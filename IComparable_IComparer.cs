using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    public class IComparable_IComparer
    {
        public static void Main()
        {
            Student s1 = new Student() { Id = 4, Name = "Arjun", Class = "First", Marks = 58.66 };
            Student s2 = new Student() { Id = 2, Name = "Ram", Class = "Fourth", Marks = 63.65 };
            Student s3 = new Student() { Id = 5, Name = "Priya", Class = "Ninth", Marks = 89.50 };
            Student s4 = new Student() { Id = 1, Name = "Anisha", Class = "Fourth", Marks = 47.96 };
            Student s5 = new Student() { Id = 3, Name = "Alex", Class = "Seventh", Marks = 75.76 };
            List<Student> li = new List<Student>() { s1, s2, s3, s4, s5 };

            li.Sort(); //we'll get an error if don't implement IComparable or IComparer since Soty() method can't sort user-defined objects without exclusive logic

            //IComparable method implemented in Student class to compare based on marks
            Console.WriteLine("Sorting based on ascending marks");
            foreach (Student s in li)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Class} {s.Marks}");
            }

            Console.WriteLine();

            li.Reverse();
            Console.WriteLine("Reversing the above sorted list");
            foreach (Student s in li)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Class} {s.Marks}");
            }

            Console.WriteLine();

            CompareStudent obj = new CompareStudent();
            li.Sort(obj); //if we use overloaded Sort() with Student parameter then it'll sort based on IComparer interface implementation
            Console.WriteLine("Sorting based on ascending id");
            foreach (Student s in li)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Class} {s.Marks}");
            }

            Console.WriteLine();

            li.Reverse();
            Console.WriteLine("Reversing the above sorted list");
            foreach (Student s in li)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Class} {s.Marks}");
            }
        }
    }

    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public double Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Marks > other.Marks)
                return 1;
            else if (this.Marks < other.Marks)
                return -1;
            else
                return 0;
        }
    }

    public class CompareStudent : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Id > y.Id)
                return 1;
            else if (x.Id < y.Id)
                return -1;
            else
                return 0;
        }
    }
}
