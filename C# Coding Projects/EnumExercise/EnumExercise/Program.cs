using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string input1 = Console.ReadLine();


            try
            {
                DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input1, true);
                if (Enum.IsDefined(typeof(DaysOfTheWeek), currentDay))
                {
                    Console.WriteLine($"{currentDay} is one of the days of the week.");
                }
                else
                {
                    Console.WriteLine($"Sorry, {currentDay} is not one of the days of the week.");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
