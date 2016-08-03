using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> candy = new List<string>();
        using (StreamReader reader = File.OpenText(args[0]))
            
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (null == line)
                    continue;
                //Number of vampires, zombies, witches, and houses can be from 0 to 100.
                //If the final number of candies is not integer, round it to the lower.
                //The number of test cases is 40.

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
                int numberOfKids = Convert.ToInt32(numberList[0]) + Convert.ToInt32(numberList[1]) + Convert.ToInt32(numberList[2]);
                int numberOfCandy = (sum / numberOfKids);

                candy.Add(numberOfCandy.ToString());
                numberList.Clear();
            }

        candy.ForEach(Console.WriteLine);
    }
}