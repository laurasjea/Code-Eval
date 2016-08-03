using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        List<string> finalList = new List<string>();
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;

                string[] array = line.Split(',');

                while (array.Length > 0)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        list.Add(array[i]);
                        array = array.Except(new string[] { array[i] }).ToArray();
                        break;
                    }
                }
                finalList.Add(string.Join(",", list.ToArray()));
                list.Clear();
        }
        finalList.ForEach(Console.WriteLine);
    }
}