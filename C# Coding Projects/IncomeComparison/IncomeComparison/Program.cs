using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            int hourRate1;
            int hoursWorked1;
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string input1 = Console.ReadLine();
            int.TryParse(input1, out hourRate1);
            Console.WriteLine("Hours worked per week?");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out hoursWorked1);
            int hourRate2;
            int hoursWorked2;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string input3 = Console.ReadLine();
            int.TryParse(input3, out hourRate2);
            Console.WriteLine("Hours worked per week?");
            string input4 = Console.ReadLine();
            int.TryParse(input4, out hoursWorked2);
            Console.WriteLine("Annual salary of Person 1");
            int annualRate1 = (hourRate1 * hoursWorked1) * 52;
            Console.WriteLine(annualRate1);
            Console.WriteLine("Annual salary of Person 2");
            int annualRate2 = (hourRate2 * hoursWorked2) * 52;
            Console.WriteLine(annualRate2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueFalse = annualRate1 > annualRate2;
            Console.WriteLine(trueFalse);
            Console.ReadLine();

        }
    }
}
