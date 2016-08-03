using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 number in a row to reverse them:");
            string stringNumbers = Console.ReadLine();
            string[] stringArray = stringNumbers.Split(' ');
            int[] numbers = Array.ConvertAll(stringArray, int.Parse);
            Console.WriteLine("Before");
            PrintArray(numbers);
            Console.WriteLine("After");
            PrintArray(numbers.Reverse().ToArray());

            Console.ReadKey(true);
        }

        private static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + " ");
            }
            Console.WriteLine("");
        }
    }  
}
