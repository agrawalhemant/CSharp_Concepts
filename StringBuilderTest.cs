using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    public class StringBuilderTest
    {
        public static void Main(string[] args)
        {
            string s = "";
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            for(int i=0; i<100000; i++)
            {
                s += i;
            }
            s1.Stop();

            StringBuilder sb = new StringBuilder("Hello");
            Stopwatch s2 = new Stopwatch();
            s2.Start();
            for (int i = 0; i <100000; i++)
            {
                sb.Append(i);
            }
            s2.Stop();
            Console.WriteLine("Time taken with string : " + s1.ElapsedMilliseconds);
            Console.WriteLine("Time taken with StringBuilder : " + s2.ElapsedMilliseconds);
        }
    }
}
