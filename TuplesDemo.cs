using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    //it's a way to returnn more than one value from a method
    internal class TuplesDemo
    {
        static void Main()
        {
            int a = 10, b = 15;
            //var obj = Calc(a, b);
            //Console.WriteLine("Sum "+ obj.sum);
            //Console.WriteLine("Product " + obj.product);

            var (Sum, Product) = Calc(a, b);
            Console.WriteLine("Sum " + Sum);
            Console.WriteLine("Product " + Product);
        }

        //static (int, int) Calc(int a, int b) //this will also work
        static (int sum, int product) Calc(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }
    }
}
