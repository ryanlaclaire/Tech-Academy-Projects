using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                bool validAge = false;
                int age = 1;
                while (!validAge)
                {
                    Console.WriteLine("Please enter your age.");
                    validAge = int.TryParse(Console.ReadLine(), out age);

                    if (!validAge) { Console.WriteLine("Please enter a whole number only with no decimals."); }
                }

                if (age <= 0)
                {
                    throw new InvalidAge();

                }
                DateTime yearsOld = DateTime.Today.AddYears(-age);
                Console.WriteLine($"\nYou were born in {yearsOld.Year}.");
            }
            catch (InvalidAge)
            {
                Console.WriteLine("Error. You must enter a number greater than zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error. That is not valid input.");
            }
                Console.ReadLine();
            
        }
    }
}
