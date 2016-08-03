using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter the number you would like to turn into a binary:");
                string stringNumber = Console.ReadLine();
                int number = Convert.ToInt32(stringNumber);
                var result = Convert.ToString(number, 2);
                Console.WriteLine(result);
            }
        }
    }
}
