using System;
using System.IO;
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
            readText = Regex.Replace(readText, @"\s", "");
            char[] userInput = readText.ToCharArray();

            // Printing the file contents
            Console.WriteLine(userInput.Length);

        }
    }
}
