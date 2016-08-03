using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter three numbers:");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int[] numbers = { a, b, c };
            Array.Sort(numbers);
            string[] numbersFinal = numbers.Select(i => i.ToString()).ToArray();

            Console.WriteLine("Sorted Numbers:");
            Console.WriteLine(string.Join(" ", numbersFinal));
            Console.ReadLine();
        }

    }
}