using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        List<string> oddNumbers = new List<string>();
        for (int k = 0; k < 100; k++)
        {
            if (k % 2 != 0)
            {
                oddNumbers.Add(k.ToString());
            }
        }
        oddNumbers.ForEach(Console.WriteLine);
    }

}