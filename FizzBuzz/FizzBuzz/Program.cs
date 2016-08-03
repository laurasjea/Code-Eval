using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> answers = new List<string>();
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
        string line = reader.ReadLine();
        if (null == line)
        continue;

        //Number of test cases is =< 20 
        //"x" is in range [1,20]
        //"y" is in range [1,20]
        //"n" is in range [21,100]

            string[] array = line.Split(' ');
            int x = Convert.ToInt32(array[0]);
            int y = Convert.ToInt32(array[1]);
            int n = Convert.ToInt32(array[2]);

            string answer = "";
            for (int i = 1; i <= n; i++)
            {
                string fizz = "F";
                string buzz = "B";

                if (i % x == 0 && i % y == 0)
                {
                    answer += fizz + buzz + " ";
                }
                else if (i % x == 0)
                {
                    answer += fizz + " ";
                }
                else if (i % y == 0)
                {
                    answer += buzz + " ";
                }
                else if (i % x != 0 && i % y != 0)
                {
                    answer += i.ToString() + " ";
                }
            }
                answers.Add(answer);
        }
        answers.ForEach(Console.WriteLine);
    }
}
