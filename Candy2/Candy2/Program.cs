using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> candy = new List<string>();
            string line = Console.ReadLine();
            string[] arrayString = line.Split(' ');
            List<string> numberList = new List<string>();

            for (int i = 0; i < arrayString.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                { 
                    numberList.Add(arrayString[i]);
                }
            }

            for (int j = 0; j < numberList.Count; j++)
            {
                string characters = "";
                char[] numbers = numberList[j].ToCharArray();

                for (int k = 0; k < numbers.Length; k++)
                {
                    if (numbers[k] >= '0' && numbers[k] <= '9')
                    {
                        characters += numbers[k];
                    }
                }

                numberList[j] = characters;
                Array.Clear(numbers, 0, numbers.Length);
            }
            int sum = 0;
            for (int i = 0; i < numberList.Count; i++)
            {
                if (i == 0)
                {
                    sum += (Convert.ToInt32(numberList[0]) * 3);
                }
                else if (i == 1)
                {
                    sum += (Convert.ToInt32(numberList[1]) * 4);
                }
                else if (i == 2)
                {
                    sum += (Convert.ToInt32(numberList[2]) * 5);
                }
                else if (i == 3)
                {
                    sum *= Convert.ToInt32(numberList[3]);
                }   
            }

            candy.Add(sum.ToString());
            numberList.Clear();
        }
    }
}
