using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class ThreadPriorityDemo
    {
        static long c1, c2;
        static void Main()
        {
            Thread t1 = new Thread(Increment1);
            Thread t2 = new Thread(Increment2);

            //see the difference with and without commenting below two lines
            t1.Priority = ThreadPriority.Lowest; 
            t2.Priority = ThreadPriority.Highest;

            t1.Start();t2.Start();
            Console.WriteLine("main thread will sleep for 10 seconds so that t1 & t2 can run for 10 seconds and don't get abort immediately");
            Thread.Sleep(10000);
            Console.WriteLine("Main thread woke up");
            
            t1.Abort(); t2.Abort();//Abort method stops the thread execution

            t1.Join(); t2.Join(); //keep Join() method for the last otherwise it'llnot let Abort() method run
            Console.WriteLine("c1 : " + c1);
            Console.WriteLine("c2 : " + c2);

            Console.WriteLine("Main thread exited");

        }

        static void Increment1()
        {
            while (true)
                c1++;
        }
        static void Increment2()
        {
            while (true)
                c2++;
        }

    }
}
