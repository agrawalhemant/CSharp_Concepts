using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    //Dictionary is a generic collection , it's like generalised form of Hashtable
    internal class DictionaryTest
    {
        static void Main()
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("Eid", 123);
            dt.Add("Name", "Hemant");
            dt.Add("Designation", "Senior System Engineer");
            dt.Add("Salary", 31011.05);
            dt.Add("Phone", 8743930321);
            dt.Add("Location", "Mathura");
            dt.Add("Active", true);

            //Dictionary stores the values in sequence unlike Hashtable
            foreach (string key in dt.Keys)
            {
                Console.WriteLine(key + ": " + dt[key]);
            }
        }
    }
}
