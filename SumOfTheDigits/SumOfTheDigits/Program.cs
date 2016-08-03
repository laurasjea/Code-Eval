using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTheDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the birthdate(ddmmyy):");
            string dateString = Console.ReadLine();
            char[] charArray = dateString.ToCharArray();

            while(true)
            {
                int sum = Add(charArray);
                string sumString = sum.ToString();
                Array.Clear(charArray, 0, charArray.Length);
                charArray = sumString.ToCharArray();

                if (charArray.Length == 1)
                {
                    Console.WriteLine("Your lucky number is: ");
                    Console.WriteLine(sum);
                    break;
                }
            }



        }

        private static int Add(char[] charArray)
        {
            int sum = 0;
            int[] array = Array.ConvertAll(charArray, c => (int)char.GetNumericValue(c));


            for (int i=0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }



    }
}
