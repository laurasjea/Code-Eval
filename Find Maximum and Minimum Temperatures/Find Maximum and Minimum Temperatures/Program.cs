using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_and_Minimum_Temperatures
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter the temperatures:");
                string tempString = Console.ReadLine();
                string[] tempStringArray = tempString.Split(' ');
                decimal[] temperatures = Array.ConvertAll(tempStringArray, decimal.Parse);

                decimal max = MaxTemperature(temperatures);
                decimal min = MinTemperature(temperatures);
                int count = CountTemperatures(temperatures);

                Console.WriteLine("Temperature Count:" + count);
                Console.WriteLine("Maximum Temperature:" + max);
                Console.WriteLine("Minimum Temperature:" + min);
                Console.WriteLine(" ");
            }
        }

        private static decimal MaxTemperature(decimal[] temperatures)
        {
            decimal max = temperatures.Max();

            return max;
        }

        private static decimal MinTemperature(decimal[] temperatures)
        {
            decimal min = temperatures.Min();

            return min;
        }

        private static int CountTemperatures(decimal[] temperatures)
        {
            int count = temperatures.Count();

            return count;
        }
    }
}
