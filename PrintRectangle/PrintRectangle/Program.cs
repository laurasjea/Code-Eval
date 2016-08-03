using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintRectangle
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Length:");
                string lengthString = Console.ReadLine();
                int lengthInteger = Convert.ToInt32(lengthString);
                Console.WriteLine("Width:");
                string widthString = Console.ReadLine();
                int widthInteger = Convert.ToInt32(widthString);

                string[] rectangle = Rectangle(lengthInteger, widthInteger);

                foreach (var i in rectangle)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
        }

        private static string[] Rectangle(int lengthInteger, int widthInteger)
        {
            List<string> array = new List<string>();

            string top = new String('*', lengthInteger);
            array.Add(top);

            for (int i=widthInteger; i > 2; i--)
            {
                string middle = new String(' ', lengthInteger - 2);
                string middleRows = "*" + middle + "*";
                array.Add(middleRows);
                widthInteger -= 1;
            }

            string bottom = new String('*', lengthInteger);
            array.Add(bottom);

            string[] rectangle = array.ToArray();

            return rectangle;
        }
    }
}
