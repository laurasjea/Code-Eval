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

                string[] numbers = line.Split(',');


                int multiple = Convert.ToInt32(numbers[1]);
                int max = Convert.ToInt32(numbers[0]);
                int by = multiple;

                while (true)
                {
                    if (multiple > max)
                    {
                        list.Add(multiple.ToString());
                        break;
                    }
                    else if (multiple < max)
                    {
                        multiple = Multiply(by, multiple);
                    }
                }
            }
        list.ForEach(Console.WriteLine);
    }
    private static int Multiply(int by, int multiple)
    {
        int number = multiple / by;
        multiple = by * (number + 1);
        return multiple;
    }
}