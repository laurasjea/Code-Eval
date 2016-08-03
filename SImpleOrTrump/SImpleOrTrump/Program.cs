using System.IO;
using System;
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

                string[] k = line.Split(' ');
                char[] cardOne = k[0].ToCharArray();
                char[] cardTwo = k[1].ToCharArray();
                string trump = k[k.Length - 1];

                char[] n = cardOne;
                int cardOneNumber = CheckCards(n);
                cardOne = n;
                n = cardTwo;
                int cardTwoNumber = CheckCards(n);
                cardTwo = n;

                char[] m = cardOne;
                string cardOneSuit = CheckSuit(m);
                cardOne = m;
                m = cardTwo;
                string cardTwoSuit = CheckSuit(m);
                cardTwo = m;

                char[] winner = CompareCards(cardOneNumber, cardTwoNumber, cardOne, cardTwo, trump, cardOneSuit, cardTwoSuit);
                string winnerString = new string(winner);
                list.Add(winnerString);
            }
        list.ForEach(Console.WriteLine);
    }
    private static int CheckCards(char[] n)
    {
        int number = 0;
        if (n[0].Equals('A'))
        {
            number += 14;
        }
        else if (n[0].Equals('K'))
        {
            number += 13;
        }
        else if (n[0].Equals('Q'))
        {
            number += 12;
        }
        else if (n[0].Equals('J'))
        {
            number += 11;
        }
        else if (n[0].Equals('1'))
        {
            number += 10;
        }
        else
        {
            number += (int)Char.GetNumericValue(n[0]);
        }

        return number;
    }

    private static char[] CompareCards(int cardOneNumber, int cardTwoNumber, char[] cardOne, char[] cardTwo, string trump, string cardOneSuit, string cardTwoSuit)
    {
        if (cardOneNumber == 14 && cardTwoNumber == 2)
        {
            if (cardTwoSuit == trump && cardOneSuit != trump)
            {
                return cardTwo;
            }
            else if (cardTwoSuit == trump && cardOneSuit == trump)
            {
                return cardOne;
            }
            else
            {
                return cardOne;
            }
        }
        else if (cardOneNumber == 2 && cardTwoNumber == 14)
        {
            if (cardOneSuit == trump && cardTwoSuit != trump)
            {
                return cardOne;
            }
            else if (cardTwoSuit == trump && cardOneSuit == trump)
            {
                return cardTwo;
            }
            else
            {
                return cardTwo;
            }
        }
        else
        {
            if (cardOneNumber > cardTwoNumber)
            {
                if (cardTwoSuit == trump && cardOneSuit != trump)
                {
                    return cardTwo;
                }
                else if (cardTwoSuit == trump && cardOneSuit == trump)
                {
                    return cardOne;
                }
                else
                {
                    return cardOne;
                }

            }
            else if (cardOneNumber < cardTwoNumber)
            {
                if (cardOneSuit == trump && cardTwoSuit != trump)
                {
                    return cardOne;
                }
                else if (cardOneSuit == trump && cardTwoSuit == trump)
                {
                    return cardTwo;
                }
                else
                {
                    return cardTwo;
                }

            }
            else if (cardOneNumber == cardTwoNumber)
            {
                char[] winner = TrumpCard(trump, cardOneSuit, cardTwoSuit, cardOne, cardTwo);
                return winner;
            }
        }
        return cardOne;
    }

    private static char[] TrumpCard(string trump, string cardOneSuit, string cardTwoSuit, char[] cardOne, char[] cardTwo)
    {
        if (cardOneSuit == trump)
        {
            return cardOne;
        }
        else if (cardTwoSuit == trump)
        {
            return cardTwo;
        }
        else
        {
            string a = new string(cardOne);
            string b = new string(cardTwo);
            string total = a + " " + b;
            char[] winner = total.ToCharArray();
            return winner;
        }

    }

    private static string CheckSuit(char[] m)
    {
        string suit = "";
        if (m.Length == 3)
        {
            suit += m[2].ToString();
        }
        else if (m.Length == 2)
        {
            suit += m[1].ToString();
        }

        return suit;
    }
}
