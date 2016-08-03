using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Statement:");
            string statement = Console.ReadLine();
            string[] array = statement.Split(' ');

            Console.WriteLine("Reverse is:");
            Array.Reverse(array);
            Console.WriteLine(string.Join(" ", array));

            Console.ReadKey(true);
        }

    }
}
