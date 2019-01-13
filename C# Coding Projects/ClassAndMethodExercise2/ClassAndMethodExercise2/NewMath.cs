using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise2
{
    public class NewMath
    {
        public static void Integers(int num1, int num2)
        {
            int change = num1 * 5;
            Console.WriteLine($"{num1} times 5 = {change}");
            Console.WriteLine($"The second number input is: {num2}");
        }
    }
}
