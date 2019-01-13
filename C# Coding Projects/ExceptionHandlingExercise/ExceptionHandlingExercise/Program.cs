using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception Handling Exercise

            List<double> numbers = new List<double>() { 45.0, 23.0, 37.0, 84.0, 72.0, 12.0, 5.0, 3.0, 7.0, 9.0, 21.0, 63.0, 88.0 };
            Console.WriteLine("Please pick a number to divide all numbers in the list by:");


            try
            {
                double divNumber = Convert.ToInt32(Console.ReadLine());

                foreach (double number in numbers)
                {
                    double answer = number / divNumber;
                    double output = Math.Round(answer, 2);
                    Console.WriteLine($"{number} divided by {divNumber} equals : {output}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\nPlease input a number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nPlease don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nProgram has left try/catch block.");
                Console.ReadLine();
            }
        }
    }
}
