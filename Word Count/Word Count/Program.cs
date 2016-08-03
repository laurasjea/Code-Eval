using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Word_Count
{
    class Phrase
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Your sentence:");
            string phrase = Console.ReadLine();

            WordCount(phrase);
        }

        public static IDictionary<string, int> WordCount(string phrase)
        {
            var match = new Dictionary<string, int>();
            string[] words = phrase.Split(new char[] { ' ', ',', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);



        }  
    }
}









