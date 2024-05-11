using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class ThreadsDemo
    {
        static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main thread";
            Console.WriteLine(t.Name);

            //for multithreading, we can assign each thread a particular work
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(); // Main thread can't exit until t1 is completed
            t2.Join(2000); // Main thread will wait for 2 seconds for thread 2 to complete otherwise it'll exit anyway
            Console.WriteLine("Main thread exiting");//main thread exited before other threads because all threads are independent, to avid this we can use Join() method.
        }

        static void Test1()
        {
            for (int i = 1;i < 100; i++)
            {
                Console.WriteLine($"Test 1 : {i}");
            }
            Console.WriteLine("Test 1 Completed, thread 1 exiting");
        }
        static void Test2()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"Test 2 : {i}");
                if (i == 25)
                {
                    Console.WriteLine("Thread 2 is going to sleep for 5 seconds");
                    Thread.Sleep(5000); //thread 2 qwill sleep for 3 seconds, Sleep is a static method so should be called using class name
                    Console.WriteLine("Thread 2 woke up");
                }                    
            }
            Console.WriteLine("Test 2 Completed, thread 2 exiting");
        }
        static void Test3()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"Test 3 : {i}");
            }
            Console.WriteLine("Test 3 Completed, thread 3 exiting");
        }
    }
}
