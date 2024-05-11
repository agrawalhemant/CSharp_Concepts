using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    public delegate void AnonymousDelegate(string str);
    public static class AnonymousMethod
    {
        static void Main(string[] args)
        {
            //here no name is given to method and still delegate is bound to a method
            AnonymousDelegate obj = (name) =>   //no need to use (string name) since paramater type already given in delegate
            {
                Console.WriteLine($"Hello {name}, have a good day!");
            };

            obj.Invoke("Hemant");

            //we can also make this as multicast delegate
            obj += (name) =>
            {
                Console.WriteLine($"What would you like to take Mr. {name}");
            };
            Console.WriteLine("\nanonymous method with muticast delegate");
            obj("Hemant");  //no need to use Invoke method
        }
    }
}
