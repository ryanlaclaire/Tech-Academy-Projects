using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number getNum = new Number();
            getNum.Amount = 34.56m;
            Console.WriteLine(getNum.Amount);
            Console.ReadLine();
        }
    }
}
