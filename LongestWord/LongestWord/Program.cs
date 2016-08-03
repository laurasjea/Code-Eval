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
                int count = 0;
                string longestWord = "";
                for (int i = 0; i < array.Length; i++)
                {
                    char[] charArray = array[i].ToCharArray();

                    int test = charArray.Length; 
                    if (test > count)
                    {
                        longestWord = array[i];
                        count = test;
                    }
                    else if (test == count)
                    {
                        longestWord = longestWord;
                    }
                    Array.Clear(charArray, 0, charArray.Length);
                }

                words.Add(longestWord);
        }
        words.ForEach(Console.WriteLine);
    }
}