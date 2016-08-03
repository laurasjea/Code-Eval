using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOddNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Add all odd numbers up to:");
                string maxStringValue = Console.ReadLine();
                int maxIntValue = Convert.ToInt32(maxStringValue);

                int[] oddArray = OddArray(maxIntValue);
                int sum = SumOdd(oddArray);

                Console.WriteLine("Sum of Odd Numbers:" + sum);
                Console.WriteLine();
            }        
        }

        private static int[] OddArray(int maxIntValue)
        {
            int[] arr = Enumerable.Range(0, maxIntValue + 1).ToArray();

            return arr;
        }

        private static int SumOdd(int[] oddArray)
        {
            int sum = 0;
            foreach (var i in oddArray)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
