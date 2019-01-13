using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList2
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string firstName2 { get; set; }
        public string lastName2 { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }
}
