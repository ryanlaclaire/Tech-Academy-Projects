using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodExercises5
{
    public class DivNumber
    {
        public void div2(int num1)
        {
            int answer = num1 / 2;
            Console.WriteLine($"\n{num1} / 2 = {answer}");
        }
        public void Output(out string input1)
        {
            input1 = "\nIt's nice to receive some good input."; ;
            Console.WriteLine("\nIsn't this just lovely?");
        }
        public void div2(string input2)
        {
            Console.WriteLine(input2);
        }
    }
    static class Step6
    {
        //  This won't do anything outside of this area.
    }
}
