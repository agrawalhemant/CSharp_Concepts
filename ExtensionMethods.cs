using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    public class TestExtensionMethods
    {
        public static void Main()
        {
            Base b = new Base();
            b.Test1();
            b.Test2();
            b.Test3(); //it'll call original Test3 method not the extenion one
            b.Test4(10);

            Console.WriteLine("\nextension method can also be used in inheritance just like normal method");
            Child c = new Child();
            c.Test1();
            c.Test2();
            c.Test3();
            c.Test4(20);

            //Fcat is extension method to struct Int32
            int a = 27;
            decimal f = a.Fact();
            Console.WriteLine($"Factorial of {a} is {f}");
        }
    }
    public class Base
    {
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }
        public void Test2()
        {
            Console.WriteLine("Method 2");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
    }
    public class Child : Base
    {
    }

    //below is the extension method which should be defined in a static class and method itself should also be static
    public static class ExtensionMethods
    {
        public static void Test4(this Base b, int a)
        {
            Console.WriteLine($"Method 4 : Extension method a = {a}");
        }
       
        public static void Test3(this Base b)
        {
            Console.WriteLine("Method 3 : Extension method");
        }

        public static Decimal Fact(this Int32 n)
        {
            if(n == 0 || n==1)
            {
                return 1;
            }
            return n * Fact(n-1);
        }
    }   

}
