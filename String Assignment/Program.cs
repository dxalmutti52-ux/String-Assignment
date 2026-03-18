using System;
using System.Text; // Needed for StringBuilder

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------
            // 1. CONCATENATE THREE STRINGS
            // -----------------------------------------

            // Create three separate strings
            string first = "Learning C# ";
            string second = "is both fun ";
            string third = "and powerful!";

            // Concatenate the three strings into one
            string fullSentence = first + second + third;

            // Print the concatenated result
            Console.WriteLine("Concatenated String:");
            Console.WriteLine(fullSentence);
            Console.WriteLine(); // Blank line for readability


            // -----------------------------------------
            // 2. CONVERT A STRING TO UPPERCASE
            // -----------------------------------------

            // Convert the full sentence to uppercase using ToUpper()
            string upperSentence = fullSentence.ToUpper();

            // Print the uppercase version
            Console.WriteLine("Uppercase Version:");
            Console.WriteLine(upperSentence);
            Console.WriteLine();


            // -----------------------------------------
            // 3. STRINGBUILDER PARAGRAPH
            // -----------------------------------------

            // Create a new StringBuilder object
            StringBuilder paragraph = new StringBuilder();

            // Append sentences one at a time
            paragraph.Append("C# is a modern programming language. ");
            paragraph.Append("It is used for building many types of applications. ");
            paragraph.Append("StringBuilder is useful when working with large amounts of text. ");
            paragraph.Append("It helps improve performance by avoiding unnecessary string copies.");

            // Print the completed paragraph
            Console.WriteLine("Paragraph Built with StringBuilder:");
            Console.WriteLine(paragraph.ToString());
            Console.WriteLine();


            // Keep the console window open
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
