using System.IO;
using System.Collections.Generic;
using System;
using System.Collections;
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
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                int number = Convert.ToInt32(line);
                int quoOne = 0;
                int remOne = 0;
                int quoTwo = 0;
                int remTwo = 0;
                int check = 0;

                if (number <= 18278 && number > 702)
                {
                    string[] m = new string[3];
                    quoOne = number / 26;
                    remOne = number % 26;
                    if (remOne == 0)
                    {
                        check = remOne;
                        m[2] = GetLetter(check);
                        quoTwo = (quoOne - 1) / 26;
                        remTwo = (quoOne - 1) % 26;
                        if (remTwo == 0)
                        {
                            check = remTwo;
                            m[1] = GetLetter(check);
                            check = quoTwo - 1;
                            m[0] = GetLetter(check);
                            list.Add(string.Join("", m));
                        }
                        else if (remTwo != 0)
                        {
                            check = remTwo;
                            m[1] = GetLetter(check);
                            check = quoTwo;
                            m[0] = GetLetter(check);
                            list.Add(string.Join("", m));
                        }
                    }
                    else if (remOne != 0)
                    {
                        check = remOne;
                        m[2] = GetLetter(check);
                        quoTwo = (quoOne) / 26;
                        remTwo = (quoOne) % 26;
                        if (remTwo == 0)
                        {
                            check = remTwo;
                            m[1] = GetLetter(check);
                            check = quoTwo - 1;
                            m[0] = GetLetter(check);
                            list.Add(string.Join("", m));
                        }
                        else if (remTwo != 0)
                        {
                            check = remTwo;
                            m[1] = GetLetter(check);
                            check = quoTwo;
                            m[0] = GetLetter(check);
                            list.Add(string.Join("", m));
                        }
                    }
                }
                else if (number <= 702 && number > 26)
                {
                    string[] m = new string[2];
                    quoOne = number / 26;
                    remOne = number % 26;

                    if (remOne == 0)
                    {
                        check = remOne;
                        m[1] = GetLetter(check);
                        check = quoOne - 1;
                        m[0] = GetLetter(check);
                        list.Add(string.Join("", m));
                    }
                    else if (remOne != 0)
                    {
                        check = remOne;
                        m[1] = GetLetter(check);
                        check = quoOne;
                        m[0] = GetLetter(check);
                        list.Add(string.Join("", m));
                    }
                }
                else if (number <= 26)
                {
                    string[] m = new string[1];
                    check = number;
                    m[0] = GetLetter(check);
                    list.Add(string.Join("", m));
                }
                
            }
        list.ForEach(Console.WriteLine);
    }
    private static string GetLetter(int check)
    {
        string letter = "";
        if (check == 1)
        {
            letter += "A";
        }
        else if (check == 2)
        {
            letter += "B";
        }
        else if (check == 3)
        {
            letter += "C";
        }
        else if (check == 4)
        {
            letter += "D";
        }
        else if (check == 5)
        {
            letter += "E";
        }
        else if (check == 6)
        {
            letter += "F";
        }
        else if (check == 7)
        {
            letter += "G";
        }
        else if (check == 8)
        {
            letter += "H";
        }
        else if (check == 9)
        {
            letter += "I";
        }
        else if (check == 10)
        {
            letter += "J";
        }
        else if (check == 11)
        {
            letter += "K";
        }
        else if (check == 12)
        {
            letter += "L";
        }
        else if (check == 13)
        {
            letter += "M";
        }
        else if (check == 14)
        {
            letter += "N";
        }
        else if (check == 15)
        {
            letter += "O";
        }
        else if (check == 16)
        {
            letter += "P";
        }
        else if (check == 17)
        {
            letter += "Q";
        }
        else if (check == 18)
        {
            letter += "R";
        }
        else if (check == 19)
        {
            letter += "S";
        }
        else if (check == 20)
        {
            letter += "T";
        }
        else if (check == 21)
        {
            letter += "U";
        }
        else if (check == 22)
        {
            letter += "V";
        }
        else if (check == 23)
        {
            letter += "W";
        }
        else if (check == 24)
        {
            letter += "X";
        }
        else if (check == 25)
        {
            letter += "Y";
        }
        else if (check == 26 || check == 0)
        {
            letter += "Z";
        }
        return letter;
    }
}