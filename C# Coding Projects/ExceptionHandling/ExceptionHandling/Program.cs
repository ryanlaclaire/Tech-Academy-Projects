using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exceptions are protections written into the code to stop the user from seeing errors.

            //      Exceptions are handled with a try/catch block
            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("\nPick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("\nDividing the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine($"\n{numberOne} divided by {numberTwo} equals {numberThree}");
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    // Console.WriteLine(ex.Message);
            //    Console.WriteLine("Please type a whole number.");       //      Both of these are examples of error messages. The first one is the actual error
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero.");      //      Yet another potential error and message
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);                          //      This will print the actual error message out
            //}
            //finally                                                     //      This will run if the try runs or even if the exceptions run.
            //{
            //    Console.ReadLine();                                     //      Often in the finally you will log to a database
            //}

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
                Console.WriteLine("Please input a number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program has left try/catch block.");
                Console.ReadLine();
            }
           
            
        }
    }
}
