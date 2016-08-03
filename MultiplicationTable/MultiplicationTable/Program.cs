using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            for (int i = 1; i < 13; i++)
            {
                string multiples = "";
                for (int j = 1; j < 13; j++)
                {
                    int m = i * j;
                    if (i * (j+1) >= 100)
                    {
                        multiples += m + " ";
                    }
                    else if (i * (j + 1) >= 10)
                    {
                        multiples += m + "  ";
                    }
                    else if (i * (j + 1) < 10)
                    {
                        multiples += m + "   ";
                    }
                }
                list.Add(multiples);
            }
            list.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
