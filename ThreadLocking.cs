using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class ThreadLocking
    {
        static void Main(string[] args)
        {
            ThreadLocking obj = new ThreadLocking();
            Thread t1 = new Thread(obj.Show);
            Thread t2 = new Thread(obj.Show);
            Thread t3 = new Thread(obj.Show);
            t1.Start();t2.Start();t3.Start();
        }

        public void Show()
        {
            //try with and without lock(this) and see teh difference
            lock(this)
            {
                Console.Write("[C# is an ");
                Thread.Sleep(3000);
                Console.WriteLine("Object Oriented Language.]");
            }
        }
    }
}
