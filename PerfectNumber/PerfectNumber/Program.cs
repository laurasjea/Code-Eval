using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number:");
                string number = Console.ReadLine();
                int numberInteger = Convert.ToInt32(number);
                bool answer = PossibleSum(numberInteger);
                string answerString = Convert.ToString(answer);
                if (answerString == "True")
                {
                    string result = "a perfect number";
                    Console.WriteLine("The result is:");
                    Console.WriteLine("given number is " + result);
                    Console.WriteLine();
                }
                if (answerString == "False")
                {
                    string result = "not a perfect number";
                    Console.WriteLine("The result is:");
                    Console.WriteLine("given number is " + result);
                    Console.WriteLine();
                }
            }
        }

        private static bool PossibleSum(int numberInteger)
        {
            int i = 1;
            int j = 1;
            for (i = 1; i * ((i + 1) / 2) <= numberInteger;)
            {
                if (PrimeCheck(i))
                {
                    int perfect = PerfectCheck(i);
                    if (perfect == numberInteger)
                    {
                        return true;
                    }
                    if (perfect != numberInteger)
                    {
                        j = j * 2;
                        i = i + j;
                    }
                }
                else
                {
                    j = j * 2;
                    i = i + j;
                }
            }
            if (i*((i+1)/2) > numberInteger)
            {
                return false;
            }
            return i != 1;
        }

        private static bool PrimeCheck(int i)
        {
            if ((i & 1) == 0)
            {
                if (i == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int j = 3; (j * j) <= i; j += 2)
            {
                if ((i % j) == 0)
                {
                    return false;
                }
            }
            return i != 1;
        }

        private static int PerfectCheck(int i)
        {
            int perfect = i * ((i + 1) / 2);
            return perfect;
        }
    }
}
