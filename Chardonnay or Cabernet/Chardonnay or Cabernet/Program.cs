using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> finalList = new List<string>();
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;

                List<string> list = new List<string>();
                string[] split = line.Split('|');
                string wine = split[0];
                char[] letter = split[1].Trim().ToCharArray();
                string[] wines = wine.Split(' ');

                wines = wines.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                for (int i = 0; i < wines.Length; i++)
                {
                    wines[i] = wines[i].Trim();
                    char[] wineLetters = wines[i].ToCharArray();
                    List<char> toss = new List<char>();

                    for (int m = 0; m < wineLetters.Length; m++)
                    {
                        toss.Add(wineLetters[m]);
                    }

                    List<string> letterList = new List<string>();

                    for (int j = 0; j < letter.Length; j++)
                    {
                        wineLetters = toss.ToArray();

                        for (int k = 0; k < wineLetters.Length; k++)
                        {
                            if (letter[j].Equals(wineLetters[k]))
                            {
                                letterList.Add(wineLetters[k].ToString());
                                toss.RemoveAt(k);
                                break;
                            }
                        }
                    }

                    if (letter.Length == letterList.Count)
                    {
                        list.Add(wines[i].ToString());
                    }

                    letterList.Clear();
                    toss.Clear();
                    Array.Clear(wineLetters, 0, wineLetters.Length);
                }

                if (list.Count == 0)
                {
                    finalList.Add("False");
                }
                else
                {
                    string final = string.Join(" ", list);
                    finalList.Add(final);
                }
            }

        finalList.ForEach(Console.WriteLine);
    }
}