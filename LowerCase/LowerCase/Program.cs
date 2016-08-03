using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                List<string> lowercase = new List<string>();

                for (int i = 0; i< args.Length; i++)
                {
                    lowercase.Add(line.ToString().ToLower());
                }

                lowercase.ForEach(Console.WriteLine);

            }
    }
}