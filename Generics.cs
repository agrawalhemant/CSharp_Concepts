using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class Generics
    {
        public bool Compare<T>(T a, T b)
        {
            if(a.Equals(b))
                return true;
            return false;
        }

        public static void Main()
        {
            Generics obj = new Generics();
            bool result1 = obj.Compare<int>(2,3);
            bool result2 = obj.Compare<string>("xchgbj", "cvgbjhk");
            bool result3 = obj.Compare<float>(2.36f, 2.36f);
            Console.WriteLine($"{result1} {result2} {result3}");

            Calculate<int> c1 = new Calculate<int>();
            c1.Add(20 , 10); c1.Sub(20, 10); c1.Mul(20, 10); c1.Div(20, 10);

            Console.WriteLine();

            Calculate<float> c2 = new Calculate<float>();
            c2.Add(20.5f, 10.7f); c2.Sub(20.5f, 10.7f); c2.Mul(20.5f, 10.7f); c2.Div(20.5f, 10.7f);
        }
    }

    public class Calculate<T> //if all the methods has same type i.e. <T> then we can pass it to class itself
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.Write(d1 + d2 + " ");
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.Write(d1 - d2 + " ");
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.Write(d1 * d2 + " ");
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.Write(d1 / d2 + " ");
        }
    }
}
