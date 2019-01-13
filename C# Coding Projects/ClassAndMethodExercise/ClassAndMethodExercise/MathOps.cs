using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise
{
    public class MathOps
    {
        public static void  AddNum(int userNum)       
        {
            int addAnswer = userNum + 5;
            Console.WriteLine($"{userNum} + 5 equals: {addAnswer}");
        }

        public static void MultNum(int userNum)
        {
            int multAnswer = userNum * 3;
            Console.WriteLine($"{userNum} * 3 equals: {multAnswer}");
        }

        public static void DivNum(int userNum)
        {
            int divAnswer = userNum / 2;
            Console.WriteLine($"{userNum} / 2 equals: {divAnswer}");
        }
    }

}
