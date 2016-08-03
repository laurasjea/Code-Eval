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

                string[] array = line.Split(' ');
                string newLine = "";

                for (int k = (array.Length - 1); k >= 0; k--)
                {
                    newLine += array[k] + " ";
                }

                Array.Clear(array, 0, array.Length);
                list.Add(newLine);
        }
        list.ForEach(Console.WriteLine);
    }
}