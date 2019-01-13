using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorsStep66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");
            string input1 = Console.ReadLine();
            int multNumber;
            if (int.TryParse(input1, out multNumber))
            {
                Console.Write("Your number times 50 = ");
                Console.WriteLine(multNumber * 50);
            }
            else
            {
                Console.WriteLine("Sorry, that's not an integer.");
            }

            Console.WriteLine("Please input another integer: ");
            string input2 = Console.ReadLine();
            int addNumber;
            if (int.TryParse(input2, out addNumber))
            {
                Console.Write("Your number plus 25 = ");
                Console.WriteLine(addNumber + 25);
            }
            else
            {
                Console.WriteLine("Sorry, that's not an integer.");
            }

            Console.WriteLine("Please input a number with a decimal: ");
            string input3 = Console.ReadLine();
            double divNumber;
            if (double.TryParse(input3, out divNumber))
            {
                Console.Write("Your number divided by 12.5 = ");
                Console.WriteLine(divNumber / 12.5);
            }
            else
            {
                Console.WriteLine("Sorry, that's not an integer.");
            }

            Console.WriteLine("Please input an integer for a comparison to 50: ");
            string input4 = Console.ReadLine();
            int boolNumber;
            if (int.TryParse(input4, out boolNumber))
            {
                bool trueFalse = boolNumber > 50;
                Console.Write("True or False. Your number is greater than 50: ");
                Console.WriteLine(trueFalse);
            }
            else
            {
                Console.WriteLine("Sorry, that's not an integer.");
            }

            Console.WriteLine("Please input another integer: ");
            string input5 = Console.ReadLine();
            int remNumber;
            if (int.TryParse(input5, out remNumber))
            {
                Console.Write("Your number, when divided by 7, has a remainder of: ");
                Console.WriteLine(remNumber % 7);
            }
            else
            {
                Console.WriteLine("Sorry, that's not an integer.");
            }
            Console.ReadLine();
        }
    }
}
