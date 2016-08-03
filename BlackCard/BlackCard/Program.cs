using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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

                string[] array = line.Split(' ');
                int count = GetNumber(array);
                array = array.Take(array.Count() - 2).ToArray();

                while (array.Length > 1)
                {
                    int counting = count;
                    while (true)
                    {
                        if (counting > array.Length)
                        {
                            counting = counting - array.Length;
                        }
                        else if (counting <= array.Length)
                        {
                            break;
                        }
                    }
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (counting == k + 1)
                        {
                            array = array.Except(new string[] { array[k] }).ToArray();
                            break;
                        }
                    }
                }
                list.Add(string.Join("", array));
                Array.Clear(array, 0, array.Length);
            }
        list.ForEach(Console.WriteLine);
    }

    private static int GetNumber(string[] array)
    {
        int count = Convert.ToInt32(array[array.Length - 1]);
        return count;
    }

}