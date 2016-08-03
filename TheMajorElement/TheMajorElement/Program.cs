using System.IO;
using System.Collections.Generic;
using System;
class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;

                string[] array = line.Split(',');
                int[] numbers = Array.ConvertAll(array, int.Parse);
                int length = array.Length;

                int answer = 0;
                for (int i = 0; i < length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < length; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            count += 1;
                        }
                    }
                    if (count > length / 2)
                    {
                        answer = numbers[i];
                    }
                }
                if (answer == 0)
                {
                    list.Add("None");
                }
                else if (answer > 0)
                {
                    list.Add(answer.ToString());

                }
            }
        list.ForEach(Console.WriteLine);
    }
}