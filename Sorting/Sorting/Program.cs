using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array Size :");

            int ArraySize = int.Parse(Console.ReadLine());

            int[] Arr = new int[ArraySize];

            int[] Ascend;

            Console.WriteLine("Enter Input Array Elements :");

            for (int i = 0; i < ArraySize; i++)
            {
                Console.WriteLine("Enter the Element number " + (i + 1) + " :");
                Arr[i] = int.Parse(Console.ReadLine());
            }

            Ascend = SortAscending(Arr);

            Console.Write("Ascending :");

            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Ascend[i] + " ");
            }
            Console.WriteLine();
        }

        private static int[] SortAscending(int[] Arr)
        {
            int[] A = Arr.OrderBy(i => i).ToArray();
            return A;
        }
    }
}
