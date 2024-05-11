using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    //delegate signature and return type should be same as referenced method
    public delegate void AddDelegate(int x, int y); //delegate for AddNums
    public delegate string SayDelegate(string str); //delegate for SayHello
    public class Delegate
    {
        public static void Main(string[] args)
        {
            Delegate obj = new Delegate();

            //obj.AddNums(100, 200);
            //string str = Delegate.SayHello("Hemant");
            //Console.WriteLine(str);

            AddDelegate add = new AddDelegate(obj.AddNums); //since AddNums is not static, we need obj to call it
            add(100, 200);

            SayDelegate say = new SayDelegate(SayHello);    //since SayHello is static, we can directly call it
            string str = say.Invoke("Hemant");  //we can directly use method or we can use Invoke
            Console.WriteLine(str);
        }

        public void AddNums(int a , int b)
        {
            Console.WriteLine(a + b);
        }

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
