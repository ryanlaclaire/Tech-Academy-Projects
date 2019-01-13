using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise4
{
    public class Optional
    {
        public static void TwoNums(int num1, int num2 = 0)
        {
            if (num1 > 0 && num2 == 0)
            {
                int answer1 = num1 * 5;
                Console.WriteLine($"You only entered 1 number. {num1} * 5 = {answer1}");
            }
            else if (num1 > 0 && num2 > 0)
            {
                int answer2 = num1 * num2;
                Console.WriteLine($"You entered 2 numbers. {num1} * {num2} = {answer2}");
            }
            else
            {
                Console.WriteLine("Well that didn't work at all.");
            }
        }
    }
}
