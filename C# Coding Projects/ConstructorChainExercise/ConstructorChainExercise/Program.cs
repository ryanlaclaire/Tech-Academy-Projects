using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const string compName = "Acme Manufacturing";

            var employee = new Employee(001);
            employee.Name = "James Smith";

            Console.WriteLine($"Welcome to {compName}, {employee.Name}!");
            Console.ReadLine();

        }
    }
}
