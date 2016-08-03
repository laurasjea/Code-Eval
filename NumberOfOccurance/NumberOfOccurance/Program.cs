using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfOccurance
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter the number: ");
                string numberString = Console.ReadLine();
                char[] charArray = numberString.ToCharArray();
                int[] numberIntegerArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));

                Console.WriteLine("Enter the number to search: ");
                string searchNumberString = Console.ReadLine();
                int searchNumber = Convert.ToInt32(searchNumberString);

                int count = MatchNumbers(numberIntegerArray, searchNumber);

                Console.WriteLine("Number of occurence of given number is: " + count);
                Console.WriteLine();
            }
        }

        private static int MatchNumbers(int[] numberIntegerArray, int searchNumber)
        {
            var count = 0;
            foreach (var i in numberIntegerArray)
            {
                if(i == searchNumber)
                {
                    count += 1;
                }
            }

            return count;
        }
    }
}
