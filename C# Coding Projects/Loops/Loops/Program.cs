using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Loops aka switch statements. This allows you to check for a wide variety of possible inputs and handle each one differently. Whereas writing a lot of if/else statements can get
            //      tedious and hard to read.
            //      A switch statement takes an input and compares it to a variety of preset values. It performs the action called for it on the value that matches.
            //      It's okay to Google the format for a switch statement.

            Console.WriteLine("Guess a number between 1 - 50?");

            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;                              //      This sets the bool to false since we are waiting for user input to say 12.

            do                                                          //      This is put in to make sure our while loop will run. Without this "do" our code could break if someone get the right answer immediately.
            {
                switch (number)
                {
                    case 47:                                                //      This basically says we are comparing the user input to the number 62.
                        Console.WriteLine("You guessed 47. Try again.");
                        Console.WriteLine("Guess a number between 1 - 50??");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;                                              //      This ends this loop.
                    case 29:                                                //      If number equals 29
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number between 1 - 50??");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 33:
                        Console.WriteLine("You guessed 33. Try again.");
                        Console.WriteLine("Guess a number between 1 - 50??");
                        number = Convert.ToInt32(Console.ReadLine());       //      Not the best use of code as there's a lot of repetition but this will demonstrate the while loop.
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:                                                //      This is used if none of the above cases are correct.
                        Console.WriteLine($"You guessed  {number}. Try again");
                        Console.WriteLine("Guess a number between 1 - 50??");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed);                                           // (!isGuessed) = (isGuessed == false) This is to start our while loop
            
            Console.ReadLine();

        }
    }
}
