using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    //ref or out are used to return more than one value by a method
    internal class RefOutDemo
    {
        public static void Main()
        {
            int m = 10;
            int n = 15;
            int p = 0, q = 0; //need to initialize while using ref, 2-way binding
            Console.WriteLine("Before using ref " + p + " " + q);
            Math1(m, n, ref p, ref q);
            Console.WriteLine("Using ref " + p + " " + q);

            Math2(m, n, out int x, out int y); //no need of initialization while using out, 1-way binding
            Console.WriteLine("Using out " + x + " " + y);
        }

        public static void Math1(int a, int b, ref int c, ref int d)
        {
            c = a + b;
            d = a * b;
        }

        public static void Math2(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a * b;
        }
    }
}
