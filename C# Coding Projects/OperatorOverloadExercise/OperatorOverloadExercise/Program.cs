using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empTest = new Employee() { ID = 001};
            Employee empTest2 = new Employee() { ID = 002 };
            List<Employee> employee = new List<Employee>();

            employee.Add(new Employee() { ID = 001, firstName = "John", lastName = "Doe" });
            employee.Add(new Employee() { ID = 002, firstName = "Abbie", lastName = "LaClaire" });
            employee.Add(new Employee() { ID = 003, firstName = "Ryan", lastName = "LaClaire" });
            employee.Add(new Employee() { ID = 004, firstName = "Jesse", lastName = "James" });

            bool result = empTest == empTest2;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
