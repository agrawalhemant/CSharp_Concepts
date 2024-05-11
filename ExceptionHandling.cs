using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class ExceptionHandling
    {
        private static void Main()
        {
            try
            {
                Console.Write("Enter first number : ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number : ");
                int b = int.Parse(Console.ReadLine());

                if (a < b)
                {
                    //throw new ApplicationException("first number should be greater than second number"); //ApplicationException
                    throw new DivideBySmallerNumberException(); //user defined Exception
                }

                int x = (a / b); //in case of double, number divided by zero results in ∞
                Console.WriteLine($"{a} / {b} = {x}");
            }
            catch (FormatException e1) //system exception
            {
                Console.WriteLine(e1.Message + " Enter a non-zero Integer");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Second number can't be zero");
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed regardless of any exception");
            }
        }
    }

    public class DivideBySmallerNumberException : ApplicationException
    {
        //ApplicationException class also inherits Exception class & Exception class has a readonly property Message, which we can override here
        public override string Message {
            get {
                return "Attempted to divide by smaller number";
            }
        }
    }
}
