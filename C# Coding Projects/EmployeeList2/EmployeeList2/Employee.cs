using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList2
{
    public class Employee: Person, IQuittable
    {
        public string firstName2;
        public string lastName2;

        public override void SayName()
        {
            Console.WriteLine("Current List of Employees:\n");
            base.SayName();

        }
        public void Quit()
        {
            firstName2 = "John";
            lastName2 = "Doe";
            Console.Write($"\nName: {firstName2} {lastName2} - ");
            Console.WriteLine("Employee has been terminated. Send final paycheck.");
        }



    }
}
