using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CsharpSection9Exercise1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Exercise 1- Write a program that reads a text file and displays the number of words.

            var path = @"C:\Users\FaysalRegal\Desktop\C# Course\Section 9 - Working with Files\Exercises\Exercise 1\Path1\random.txt";

            // Calling the ReadAllText(String, Encoding) function
            string readText = File.ReadAllText(path);
            var words = readText.Split(' ');

            // Printing the file contents
            Console.WriteLine("Number of words: " + words.Length);




            //Exercise 2 - Write a program that reads a text file and displays the longest word in the file.

            List<int> lengthOfWords = new List<int>();
            var largestWord = words[0];
      
            for (int i = 0; i < words.Length; i++)
            {
                lengthOfWords.Add(words[i].Length);
                if (words[i].Length > largestWord.Length)
                {
                    largestWord = words[i];
                }
            }

            Console.WriteLine(largestWord);
        }
    }
}
