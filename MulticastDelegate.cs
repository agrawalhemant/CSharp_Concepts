using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    public delegate void CalcDelegate(int a, int b);
    public class MulticastDelegate
    {
        public static void Main(string[] args)
        {
            MulticastDelegate obj = new MulticastDelegate();
            obj.Add(20, 10);
            obj.Sub(20, 10);
            obj.Mul(20, 10);

            Console.WriteLine("\nUsing delegate");
            //CalcDelegate calc = new CalcDelegate(obj.Add);
            CalcDelegate calc = obj.Add; //we can directly make object of delegate like this
            calc = calc + obj.Sub; //now calc contains reference of sub also
            calc = calc + obj.Mul; //now calc contains reference of mul also

            calc.Invoke(20, 10); //all the referenced functions will invoke sequentially as added to delegate instance
        }
        public void Add(int a, int b) {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
    }
}
