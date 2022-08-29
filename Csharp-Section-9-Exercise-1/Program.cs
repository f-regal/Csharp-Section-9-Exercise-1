using System;
using System.IO;
using System.Text;

namespace CsharpSection9Exercise1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Exercise 1- Write a program that reads a text file and displays the number of words.

            var path = @"/Users/faysalregal/Desktop/C# Fundamentals/Section 9 Working with Files/Exercises/Exercise 1/Exercise-1-Text-File/Exercise-1";

            // Calling the ReadAllText(String, Encoding)
            // function
            string readText = File.ReadAllText(path);

            // Printing the file contents
            Console.WriteLine(readText.Length);

            //remember to split the sentence and count only the letters
        }
    }
}
