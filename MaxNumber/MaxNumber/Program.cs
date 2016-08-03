using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{

    public class addition
    {
        public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] numberString = numbers.Split(' ');
            int[] integerArray = Array.ConvertAll(numberString, int.Parse);
            int large = LargestNumber(integerArray);

            Console.WriteLine("The largest value is " + large);
        }

        private static int LargestNumber(int[] integerArray)
        {
            int maxItem = 0;
            int N = integerArray.Length;
            for (int i=0; i < N; i++)
            {
                if(integerArray[i] > maxItem)
                {
                    maxItem = integerArray[i];
                }
            }
            return maxItem;
        }
    }
}

