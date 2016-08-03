using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulStrings
{
    class Program
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<string> letters = new List<string>();
            string[] array = line.Split(' ');
            CountingLetters(array, letters);
        }

        public static void CountingLetters(string[] array, List<string> letters)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].All(char.IsLetter))
                {
                    char[] charArray = array[i].ToCharArray();
                    CountLetters();
                }
                
                
            }
        }

        public static void CountLetters(charArra)
    }
}
