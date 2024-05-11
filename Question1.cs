/*
There can be majorly 3 kind of exceptions with this problem. 
1. FormatException :  if user enters a or b in wrong format(anything other than number)
2. DivideByZero (custom): if user enter b as 0 then there should be dividebyzero exception. In C#, Floating-point arithmetic overflow or division by zero never throws an exception,
3. square root of negative number (custom): if user enters value of a less than -1/3 then square root will become negative
 */

using System;

namespace FirstCode
{
    internal class Question1
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                double x = FindX(a, b);
                Console.WriteLine($"x = {x}");
            }
            catch(FormatException)
            {
                Console.WriteLine("a and b can only be numbers");
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }
        public static double FindX(double a, double b)
        {
            // x = root(3a+1)/b
            if(3*a+1 < 0)
            {
                throw new CustomException("a can't be less than -1/3");
            }
            if (b == 0)
            {
                throw new CustomException("b can't be zero");
            }
            
            return (Math.Sqrt(3 * a + 1))/b;
        }
    }

    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}
