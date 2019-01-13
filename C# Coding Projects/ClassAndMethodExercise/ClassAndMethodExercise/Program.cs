using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a whole number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            MathOps.AddNum(userNum);
            MathOps.MultNum(userNum);
            MathOps.DivNum(userNum);
            Console.ReadLine();
        }
    }
}
