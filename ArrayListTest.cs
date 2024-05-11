using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class ArrayListTest
    {
        public static void Main()
        {
            ArrayList a = new ArrayList();
            //ArrayList a = new ArrayList(10); //we can give default capacity to ArrayList by passing value in parameter
            //a.Capacity = 10; //we can also give custom capacity like this
            Console.WriteLine(a.Capacity); // by default it is zero
            a.Add(100);
            Console.WriteLine(a.Capacity); // adding 1 iteam makes the capacity 4
            a.Add(200); a.Add(300); a.Add(400);
            Console.WriteLine(a.Capacity); // capacity will not increase until all of it is utilized
            a.Add(500); 
            a.Add("hemant"); //ArrayList is non-generic Collection
            Console.WriteLine(a.Capacity); //capacity doubles after it is filled
            foreach (object obj in a)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
            a.Insert(3, 350); // this will insert 350 at 3rd index of ArrayList
            a.Insert(3, 350);
            foreach (object obj in a)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
            a.Remove(350); //removes first occurence of 350 in ArrayList
            foreach (object obj in a)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
            a.RemoveAt(3); //removes the item at 3rd index in ArrayList
            foreach (object obj in a)
            {
                Console.Write(obj + " ");
            }
        }
    }
}
