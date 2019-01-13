using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //      This is to show some of the different ways you can use strings

            //      Escape sequences

            string name = "Jesse";
            string quote = $"The man said, \"Hark, for {name} hath come.\""; //  This allows you put quotes into a string.
            string info = $"This is to see how this can work. \nBecause... \tit is interesting.";    //      The \n puts everything that follows onto the next line. The \t creates a tab.
            string fileName = "C:\\Users\\Ryan";                             // A double backslash (\\) will put a backslash into the string
            string fileName2 = @"C:\Users\Ryan";                            // The @ will tell C# that everything in the string is part of it. There's no escape sequences.

            //Console.WriteLine(quote);
            //Console.WriteLine(info);
            //Console.WriteLine(fileName);


            //      Calling functions

            bool trueOrFalse = name.Contains("s");      //  Allows value trueOrFalse to search name
            trueOrFalse = name.EndsWith("s");

            int length = quote.Length;                   //  Find length of a string

            name = name.ToUpper();                      //  Converts name to all uppercase
            name = name.ToLower();                      //  Converts name to all lowercase

            

            //      String Builder
            //          Strings are immutable (can't be changed) this can cause a problem with really large amounts of data.
            //          The solution is String Builder

            StringBuilder sb = new StringBuilder();     //      This creates the class of String Builder which can expand or collapse as needed withouth tying up memory

            sb.Append("\nI have to say that I am really enjoying this course. ");
            sb.Append("I truly appreciate the way Jesse has explained every step ( even when making mistakes). ");
            sb.Append("I hope this continues on throughout this course as we get into more complex uses of the C# language.");

            string start = "Hi, my name is ";
            string middle = "Ryan LaClaire ";
            string end = "and I like pizza.";
            middle = middle.ToUpper();

            Console.WriteLine(start + middle + end);
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
