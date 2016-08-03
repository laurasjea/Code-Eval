using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192), Console.InputEncoding, false, 8192));
            string line = reader.ReadLine();
            if (null == line)
                continue;
                string[] m = line.Split('|');
                int length = FindLength(m);
                int[] largerNumbers = new int[length];

                for (int k = 0; k < length; k++)
                {
                    largerNumbers[k] = -1000;
                }

                for (int i = 0; i < m.Length; i++)
                {
                    string[] numberString = m[i].Split(' ');
                    numberString = numberString.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    int[] numberIntegers = Array.ConvertAll(numberString, int.Parse);

                    for (int k = 0; k < numberIntegers.Length; k++)
                    {
                        if (numberIntegers[k] > largerNumbers[k])
                        {
                            largerNumbers[k] = numberIntegers[k];
                        }
                    }
                }
                string final = string.Join(" ", largerNumbers);
                list.Add(final);
            }
        list.ForEach(Console.WriteLine);
    }

    private static int FindLength(string[] m)
    {
        string[] numberString = m[0].Split(' ');
        Array.Resize<string>(ref numberString, numberString.Length - 1);
        int[] array = Array.ConvertAll(numberString, int.Parse);
        int length = array.Count();
        return length;
    }

}