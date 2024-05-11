using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    //List is a generic collection , it's like generic form of ArrayList
    internal class ListTest
    {
        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(10); li.Add(20); li.Add(30); li.Add(40);
            //li.Add("r"); //can't store anything but int
            for(int i = 0; i<li.Count; i++)
            {
                Console.Write(li[i] + " ");
            }

            Console.WriteLine();
            li.Insert(3, 35);
            foreach(int i in li)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            li.RemoveAt(1);
            foreach (int i in li)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Customer c1 = new Customer { CustId = 2352, Name = "Hemant", Address = "Mathura", Balance = 30011.69 };
            Customer c2 = new Customer { CustId=2356, Name = "Dhruv" , Address="Yamunanagar", Balance =35896.38  };

            List<Customer> lc = new List<Customer>();
            //List<Customer> lc = new List<Customer>() { c1, c2 }; //either we can add items like this all at once
            lc.Add(c1); lc.Add(c2);// or we can add them one by one using Add() method
            foreach(Customer c in lc)
            {
                Console.WriteLine(c.CustId + " " + c.Name + " " + c.Address + " " + c.Balance);
            }

            //Console.WriteLine("ListTest");
        }
    }

    public class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }
    }
}
