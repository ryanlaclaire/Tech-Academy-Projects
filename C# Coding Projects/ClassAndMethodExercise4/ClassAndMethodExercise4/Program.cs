using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Optional option = new Optional();
            Console.WriteLine("You will be asked to input two numbers. " +
                "\nThe first number is necessary. The second number is optional.\n");
            Console.WriteLine("Please input the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(Optional) Please input the second number:");
            string input = Console.ReadLine();
            int num2 = 0;
            if (!int.TryParse(input, out num2))
            {
                Optional.TwoNums(num1);
            }
            else
            {
                Optional.TwoNums(num1, num2);
            }
       
            Console.ReadLine();
        }
    }
}
