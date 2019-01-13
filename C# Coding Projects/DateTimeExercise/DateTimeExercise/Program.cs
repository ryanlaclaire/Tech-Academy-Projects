using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{DateTime.Now}\n");
            Console.WriteLine("Please input a whole number.");
            int getNum = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = DateTime.Now.AddHours(getNum);
            Console.WriteLine($"\nThe time in {getNum} hours will be {futureTime}.");
            Console.ReadLine();

        }
        
    }
}
