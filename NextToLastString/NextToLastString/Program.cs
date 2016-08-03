using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> words = new List<string>();
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;

                string[] array = line.Split(' ');

                words.Add((array[(array.Length - 2)]));

        }

        words.ForEach(Console.WriteLine);
    }
}