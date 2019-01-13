using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMath newMath = new NewMath();
            NewMath.Integers(3, 9);
            NewMath.Integers(num1: 5, num2: 11);

            Console.ReadLine();
            

            //newMath = Integers(3, 9);      //This line won't find Integers. Visual Studio says it doesn't exist.
            
        }
    }
}
