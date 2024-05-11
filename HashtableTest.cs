using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class HashtableTest
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 123);
            ht.Add("Name", "Hemant");
            ht.Add("Designation", "Senior System Engineer");
            ht.Add("Salary", 31011.05);
            ht.Add("Phone", 8743930321);
            ht.Add("Location", "Mathura");

            //hashtable keeps keys, values and their hashcodes. All operation (even search) is based on hashcodes that's why values are not stored sequentially in hashtable
            Console.WriteLine("HashCode for Name = " + ht["Name"].GetHashCode());
            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key + ": " + ht[key]);
            }
        }
    }
}
