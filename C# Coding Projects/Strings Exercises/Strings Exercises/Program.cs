using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
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
