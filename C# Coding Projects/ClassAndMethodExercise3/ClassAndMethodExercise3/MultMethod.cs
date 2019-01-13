using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise3
{
    public class MultMethod
    {
        public static void Answer(int num1)
        {
            int answer1 = num1 * 2;
            Console.WriteLine($"{num1} * 2 = {answer1}");
        }
        public static void Answer(decimal num2)
        {
            int num2b = Convert.ToInt32(num2);
            int answer2 = num2b + 25;
            Console.WriteLine($"{num2} was changed to an integer. {num2b} + 25 = {answer2}");
        }
        public static void Answer(string str1)
        {            
            int num3 = Convert.ToInt32(str1);
            int answer3 = num3 - 5;
            Console.WriteLine($"The string {str1} has been changed to an integer. {num3} - 5 = {answer3}");
        }
    }
}
