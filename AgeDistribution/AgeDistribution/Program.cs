using System;
using System.IO;
using System.Collections.Generic;

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

                int age = Convert.ToInt32(line);

                string p = Age(age);
                list.Add(p);
            }

        list.ForEach(Console.WriteLine);
    }

    private static string Age(int age)
    {
        string s = "";
        if (age >= 0 && age <= 2)
        {
            s += "Still in Mama's arms";
        }
        else if (age >= 3 && age <= 4)
        {
            s += "Preschool Maniac";
        }
        else if (age >= 5 && age <= 11)
        {
            s += "Elementary school";
        }
        else if (age >= 12 && age <= 14)
        {
            s += "Middle school";
        }
        else if (age >= 15 && age <= 18)
        {
            s += "High school";
        }
        else if (age >= 19 && age <= 22)
        {
            s += "College";
        }
        else if (age >= 23 && age <= 65)
        {
            s += "Working for the man";
        }
        else if (age >= 66 && age <= 100)
        {
            s += "The Golden Years";
        }
        else if (age > 100 && age < 0)
        {
            s += "This program is for humans";
        }

        return s;
    }
}