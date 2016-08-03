using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSamplesOfANumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Declare N:");
                string nNumber = Console.ReadLine();
                Console.WriteLine("Declare M:");
                string mNumber = Console.ReadLine();
                int nInteger = Convert.ToInt32(nNumber);
                int mInteger = Convert.ToInt32(mNumber);

                int[] lastSamples = FindNumbers(nInteger, mInteger);

                Console.WriteLine("Last Samples: " + string.Join(" ",lastSamples));
                Console.WriteLine();
            }
        }

        private static int[] FindNumbers(int nInteger, int mInteger)
        {
            int[] array = Enumerable.Range(nInteger - mInteger, mInteger).ToArray();
            Array.Reverse(array);
            return array;
        }
    }
}
