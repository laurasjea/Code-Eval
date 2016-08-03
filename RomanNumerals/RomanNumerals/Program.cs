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

                char[] m = Characters(line);
                string roman = "";
                roman = Length(m, roman);
                list.Add(roman);
                Array.Clear(m, 0, m.Length);
        }

        list.ForEach(Console.WriteLine);
    }

    private static char[] Characters(string line)
    {
        char[] m = line.ToCharArray();
        return m;
    }

    public static string Reverse(char[] m)
    {
        string l = "";
        for (int i = (m.Length - 1); i >= 0; i--)
        {
            l += m[i];
        }
        Array.Clear(m, 0, m.Length);
        m = l.ToCharArray();
        Array.Resize<char>(ref m, (m.Length - 1));
        string reverse = "";
        for (int j = (m.Length - 1); j >= 0; j--)
        {
            reverse += m[j];
        }
        return reverse;
    }

    public static string Length(char[] m, string roman)
    {
        while (true)
        {
            if (m.Length == 4)
            {
                roman += Thousands(m);
                string reverse = Reverse(m);
                Array.Clear(m, 0, m.Length);
                m = reverse.ToCharArray();
            }
            else if (m.Length == 3)
            {
                roman += Hundreds(m);
                string reverse = Reverse(m);
                Array.Clear(m, 0, m.Length);
                m = reverse.ToCharArray();
            }
            else if (m.Length == 2)
            {
                roman += Tens(m);
                string reverse = Reverse(m);
                Array.Clear(m, 0, m.Length);
                m = reverse.ToCharArray();
            }
            else if (m.Length == 1)
            {
                roman += Ones(m);
                break;
            }
        }
        return roman;
    }

    private static string Thousands(char[] m)
    {
        string number = "";
        string s = Convert.ToString(m[0]);
        int c = Convert.ToInt32(s);
        if (c == 3)
        {
            number = "MMM";
        }
        else if (c == 2)
        {
            number = "MM";
        }
        else if (c == 1)
        {
            number = "M";
        }
        else if (c == 0)
        {
            number = "";
        }

        return number;
    }

    private static string Hundreds(char[] m)
    {
        string number = "";
        string s = Convert.ToString(m[0]);
        int c = Convert.ToInt32(s);

        while (true)
        {
            if (c == 9)
            {
                number = "CM";
                break;
            }
            else if (c >= 5 && c < 9)
            {
                number += "D";
                c = c - 5;
            }
            else if (c < 5)
            {
                if (c == 4)
                {
                    number += "CD";
                    break;
                }
                else if (c == 3)
                {
                    number += "CCC";
                    break;
                }
                else if (c == 2)
                {
                    number += "CC";
                    break;
                }
                else if (c == 1)
                {
                    number += "C";
                    break;
                }
                else if (c == 0)
                {
                    break;
                }
            }
        }

        return number;
    }

    private static string Tens(char[] m)
    {
        string number = "";
        string s = Convert.ToString(m[0]);
        int c = Convert.ToInt32(s);

        while (true)
        {
            if (c == 9)
            {
                number = "XC";
                break;
            }
            else if (c >= 5 && c < 9)
            {
                number += "L";
                c = c - 5;
            }
            else if (c < 5)
            {
                if (c == 4)
                {
                    number += "XL";
                    break;
                }
                else if (c == 3)
                {
                    number += "XXX";
                    break;
                }
                else if (c == 2)
                {
                    number += "XX";
                    break;
                }
                else if (c == 1)
                {
                    number += "X";
                    break;
                }
                else if (c == 0)
                {
                    break;
                }
            }
        }

        return number;
    }

    private static string Ones(char[] m)
    {
        string number = "";
        string s = Convert.ToString(m[0]);
        int c = Convert.ToInt32(s);

        while (true)
        {
            if (c == 9)
            {
                number = "IX";
                break;
            }
            else if (c >= 5 && c < 9)
            {
                number += "V";
                c = c - 5;
            }
            else if (c < 5)
            {
                if (c == 4)
                {
                    number += "IV";
                    break;
                }
                else if (c == 3)
                {
                    number += "III";
                    break;
                }
                else if (c == 2)
                {
                    number += "II";
                    break;
                }
                else if (c == 1)
                {
                    number += "I";
                    break;
                }
                else if (c == 0)
                {
                    break;
                }
            }
        }
        return number;
    }
}