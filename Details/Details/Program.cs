using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test size is 40
            //Matricies are M,N (2<=M<=10, 2<=N<=10)

            //New Lists
            List<string> matrixList = new List<string>();
            List<string> countPerLine = new List<string>();

            foreach (var line in File.ReadLines(args[0]))
            {
                ////Starting new empty string
                //string line = "";

                //Starting new empty integer
                int lineCount = 0;

                //Check to make sure the line is within the constraints
                CheckLine(line);

                //If they are
                if (CheckLine(line) == true)
                {
                    //Add them to the list
                    matrixList.Add(line);

                    //And check their count 
                    lineCount = Count(line);

                    //Add their count to the list
                    countPerLine.Add(lineCount.ToString());

                    //Display only when the List count = 40
                    if (matrixList.Count == 40)
                    {
                        countPerLine.ForEach(Console.WriteLine);
                    }
                }
                else
                {
                    //If not true, then try again
                    Console.WriteLine("Please try again");
                }
            }

            
        }

        public static bool CheckLine(string line)
        {
            //Split the different rows
            string[] array = line.Split(',');
            
            //Start a list to add the individual lines of section 
            List<string> charList = new List<string>();

            //Check if the array is between 2 and 10 lines
            if (array.Length >= 2 && array.Length <= 10)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    //Convert to characters to check the length 
                    char[] charArray = array[i].ToCharArray();

                    //character check if between numbers 
                    if (charArray.Length >= 2 && charArray.Length <= 10)
                    {
                        //If that array has correct characters, add it to the list 
                        charList.Add(array[i]);
                    }
                    else
                    {
                        //Show erre
                        Console.WriteLine("Error 101: Invalid Character Length");
                        return false;
                    }

                    //Clear the array so we can use it again
                    Array.Clear(charArray, 0, charArray.Length);


                }

                //Make sure the columns match the rows
                if (CheckCharacters(charList) == true)
                {
                    return true; 
                }
                else
                {
                    return false;
                }
            }
            else
            {
                //Display error message if the array length is not correct
                Console.WriteLine("Error 103: Invalid Array Length");
                return false;
            }
        }

        private static bool CheckCharacters(List<string> charList)
        {
            //Checking to make sure all of the lengths of characters are the same 
            int check = charList[0].Length;
            for (int i = 0; i < charList.Count; i++)
            {
                char[] checking = charList[i].ToCharArray();
                if (checking.Length == check)
                {
                    //Make sure equal
                    check = checking.Length;
                } 
                else
                {
                    //If not equal, then display error
                    Console.WriteLine("Error 102: Lines must all be the same length.");
                    return false;
                }
                //Clear array so it can be used again
                Array.Clear(checking, 0, checking.Length);
            }
            //If it all checks out, return true
            return true;
        }

        public static int Count(string line)
        {
            //10 so that every possible number can be lower
            int count = 10;

            //Spliting up the arrays
            string[] array = line.Split(',');

            //For every line in the string array
            for (int j=0; j<array.Length; j++)
            {
                //Take the array line and convert it to characters
                char[] dots = array[j].ToCharArray();

                //For each character, check where the first "Y" comes into play
                for (int i = 0; i < dots.Length; i++)
                {
                    if (dots[i].Equals('Y'))
                    {
                        //Wherever the first "Y" is, resize the array to fit that size
                        Array.Resize(ref dots, i + 1);
                        break;
                    }
                }

                //Now count the dots
                int dotsCount = 0;

                //For each line in the new size array, count the dots
                for (int k = 0; k < dots.Length; k++)
                {
                    if (dots[k].Equals('.'))
                    {
                        dotsCount += 1;
                    }
                }

                //If the number of dots in that line is the shortest, store it in the count
                if (dotsCount < count)
                {
                    count = dotsCount;
                }
                //Clear the dots array for the next line of "X"'s and "Y"s
                Array.Clear(dots, 0, dots.Length);
            }
            //Clear the array so that it can be used for the next line
            Array.Clear(array, 0, array.Length);

            //Return the lowest number stored in count
            return count;
        }
    }
}
