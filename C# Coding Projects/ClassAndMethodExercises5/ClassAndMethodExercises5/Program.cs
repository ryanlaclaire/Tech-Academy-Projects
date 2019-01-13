using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            DivNumber divNum = new DivNumber();
            Console.WriteLine("Input a number and we will divide it by 2.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            divNum.div2(num1);
            divNum.Output(out string input2);
            divNum.div2(input2);
            Console.ReadLine();

        }
    }
}
