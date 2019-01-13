using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //      While loop

            //decimal num = 0.01m;
            //int days = 2;

            //Console.WriteLine("Let's see what happens if we double a penny every day for 30 days.");
            //Console.WriteLine("Day 1 : 0.01");
            //while (days <= 30)
            //{
            //    decimal sum = num + num; 
            //    Console.WriteLine($"Day {days} : {sum}");
            //    num = sum;
            //    days++;
                
            //}
            //Console.ReadLine();


            //      Do While loop
            DateTime currentDate = DateTime.Now;
            DateTime XmasDay = new DateTime(2018, 12, 25, 12, 0, 0);
            TimeSpan daysLeft = XmasDay.Subtract(currentDate);
            double daysToGo = daysLeft.TotalDays;

            do
            {

                Console.WriteLine($"You only have {daysLeft.Days} days left until Christmas!");
                break;
            }
            while (daysToGo > 0);
            Console.ReadLine();

            
        }
    }
   
}