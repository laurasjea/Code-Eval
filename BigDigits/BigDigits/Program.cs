using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string line = Console.ReadLine();
            string one = "";
            string two = "";
            string three = "";
            string four = "";
            string five = "";
            string six = "";
            string number = "";

            char[] m = line.ToCharArray();

            for (int i = 0; i < m.Length; i++)
            {
                if (Char.IsDigit(m[i]))
                {
                    number += m[i];
                }
            }

            char[] p = number.ToCharArray();

            for (int k = 0; k < p.Length; k++)
            {
                int check = (int)char.GetNumericValue(p[k]);
                if (check == 0)
                {
                    string[] zeroA = Zero();
                    one += zeroA[0]; 
                    two += zeroA[1];
                    three += zeroA[2];
                    four += zeroA[3];
                    five += zeroA[4];
                    six += zeroA[5];
                }
                else if (check == 1)
                {
                    string[] oneA = One();
                    one += oneA[0];
                    two += oneA[1];
                    three += oneA[2];
                    four += oneA[3];
                    five += oneA[4];
                    six += oneA[5];
                }
                else if (check == 2)
                {
                    string[] twoA = Two();
                    one += twoA[0];
                    two += twoA[1];
                    three += twoA[2];
                    four += twoA[3];
                    five += twoA[4];
                    six += twoA[5];
                }
                else if (check == 3)
                {
                    string[] threeA = Three();
                    one += threeA[0];
                    two += threeA[1];
                    three += threeA[2];
                    four += threeA[3];
                    five += threeA[4];
                    six += threeA[5];
                }
                else if (check == 4)
                {
                    string[] fourA = Four();
                    one += fourA[0];
                    two += fourA[1];
                    three += fourA[2];
                    four += fourA[3];
                    five += fourA[4];
                    six += fourA[5];
                }
                else if (check == 5)
                {
                    string[] fiveA = Five();
                    one += fiveA[0];
                    two += fiveA[1];
                    three += fiveA[2];
                    four += fiveA[3];
                    five += fiveA[4];
                    six += fiveA[5];
                }
                else if (check == 6)
                {
                    string[] sixA = Six();
                    one += sixA[0];
                    two += sixA[1];
                    three += sixA[2];
                    four += sixA[3];
                    five += sixA[4];
                    six += sixA[5];
                }
                else if (check == 7)
                {
                    string[] sevenA = Seven();
                    one += sevenA[0];
                    two += sevenA[1];
                    three += sevenA[2];
                    four += sevenA[3];
                    five += sevenA[4];
                    six += sevenA[5];
                }
                else if (check == 8)
                {
                    string[] eightA =   Eight();
                    one += eightA[0];
                    two += eightA[1];
                    three += eightA[2];
                    four += eightA[3];
                    five += eightA[4];
                    six += eightA[5];
                }
                else
                {
                    string[] nineA = Nine();
                    one += nineA[0];
                    two += nineA[1];
                    three += nineA[2];
                    four += nineA[3];
                    five += nineA[4];
                    six += nineA[5];
                }
            }

            list.Add(one);
            list.Add(two);
            list.Add(three);
            list.Add(four);
            list.Add(five);
            list.Add(six);
            list.ForEach(Console.WriteLine);
            Console.ReadLine();
        }

        public static string[] Zero()
        {
            string[] zero = { "-**--", "*--*-", "*--*-", "*--*-", "-**--", "-----" };
            return zero;
        }
        public static string[] One()
        {
            string[] one = { "--*--", "-**--", "--*--", "--*--", "-***-", "-----" };
            return one;
        }
        public static string[] Two()
        {
            string[] two = { "***--", "---*-", "-**--", "*----", "****-", "-----" };
            return two;
        }
        public static string[] Three()
        {
            string[] three = { "***--", "---*-", "-**--", "---*-", "***--", "-----" };
            return three;
        }
        public static string[] Four()
        {
            string[] four = { "-*---", "*--*-", "****-", "---*-", "---*-", "-----" };
            return four;
        }
        public static string[] Five()
        {
            string[] five = { "****-", "*----", "***--", "---*-", "***--", "-----" };
            return five;
        }
        public static string[] Six()
        {
            string[] six = { "-**--", "*----", "***--", "*--*-", "-**--", "-----" };
            return six;
        }
        public static string[] Seven()
        {
            string[] seven = { "****-", "---*-", "--*--", "-*---", "-*---", "-----" };
            return seven;
        }
        public static string[] Eight()
        {
            string[] eight = { "-**--", "*--*-", "-**--", "*--*-", "-**--", "-----" };
            return eight;
        }
        public static string[] Nine()
        {
            string[] nine = { "-**--", "*--*-", "-***-", "---*-", "-**--", "-----" };
            return nine;
        }

    }

        
    
}
