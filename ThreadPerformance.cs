using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class ThreadPerformance
    {
        static void Main()
        {
            Stopwatch s1 = new Stopwatch();

            s1.Start();
            Increment1(); Increment2();
            s1.Stop();
            Console.WriteLine("Time taken using single-threaded model : " + s1.ElapsedMilliseconds);

            Console.WriteLine();

            Stopwatch s2 = new Stopwatch();
            Thread t1 = new Thread(Increment1);
            Thread t2 = new Thread(Increment2);

            s2.Start();
            t1.Start(); t2.Start();
            t1.Join(); t2.Join();
            s2.Stop();
            Console.WriteLine("Time taken using multi-threaded model : " + s2.ElapsedMilliseconds);

        }

        static void Increment1()
        {
            long c = 0;
            for(long i = 0; i<= 1000000000; i++)
            {
                c++;
            }
            Console.WriteLine("IncrementalCounter1 : " + c);
        }
        static void Increment2()
        {
            long c = 0;
            for (long i = 0; i <= 1000000000; i++)
            {
                c++;
            }
            Console.WriteLine("IncrementalCounter2 : " + c);
        }
    }
}
