//find largest number in array

using System;

namespace FirstCode
{
    internal class Question2
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number of elements in input array : ");
                long n = Convert.ToInt64(Console.ReadLine());
                long[] numbers = new long[n];

                for(int i = 0; i<n; i++)
                {
                    numbers[i] = Convert.ToInt64(Console.ReadLine());
                }

                Console.WriteLine("Largest number in array is : " + FindLargestNumber(numbers));
            }
            catch(FormatException)
            {
                Console.WriteLine("Only integers can be taken as input");
            }
            catch(CustomExceptions e)
            {
                Console.WriteLine("Error - " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static long FindLargestNumber(long[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new CustomExceptions("[Invalid input: Array is null or empty]");
            }

            long largest = long.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                //if current element in array is larger than current largest element than value of current lagest element will be updated to current element in array
                if (array[i] > largest)
                {
                    largest = array[i];
                }
            }

            return largest;
        }

    }

    public class CustomExceptions : Exception
    {
        public CustomExceptions(string message) : base(message) { }
    }
}
