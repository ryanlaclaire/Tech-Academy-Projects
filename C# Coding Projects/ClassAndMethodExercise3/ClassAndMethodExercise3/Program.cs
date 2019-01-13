using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            MultMethod newMethod = new MultMethod();
            MultMethod.Answer(num1: 12);
            MultMethod.Answer(num2: 11.5m);
            MultMethod.Answer(str1: "15");
            Console.ReadLine();
        }
    }
}
