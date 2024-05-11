using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class LocalFunctionDemo //function defined within the function
    {
        static void Main()
        {
            void AddNums(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            AddNums(1, 2);

            void AddNums2(int a, int b, ref int x)
            {
                x = a + b;
            }

            int x = 0, y = 0;
            AddNums2(4, 5, ref x);
            Console.WriteLine($"x : {x}");

            void AddNums3(int a, int b, out int p){
                p = a + b;
            }

            AddNums3(7, 2, out int p);
            Console.WriteLine($"p : {p}");
        }
    }
}
