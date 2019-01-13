using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee getName = new Employee() { firstName = "Sample", lastName = "Student" };
            getName.SayName();

            IQuittable isgone = new Employee() { firstName2 = "John", lastName2 = "Doe" };

            isgone.Quit();
            Console.ReadLine();
        }
    }
}
