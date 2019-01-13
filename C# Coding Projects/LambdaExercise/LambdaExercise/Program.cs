using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employ = new Employee();
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { EmployeeID = 001, FirstName = "Joe", LastName = "Doe" });
            employees.Add(new Employee() { EmployeeID = 002, FirstName = "Abbie", LastName = "LaClaire" });
            employees.Add(new Employee() { EmployeeID = 003, FirstName = "Ryan", LastName = "LaClaire" });
            employees.Add(new Employee() { EmployeeID = 004, FirstName = "Jesse", LastName = "James" });
            employees.Add(new Employee() { EmployeeID = 005, FirstName = "Joe", LastName = "Zavala" });
            employees.Add(new Employee() { EmployeeID = 006, FirstName = "Shane", LastName = "Ball" });
            employees.Add(new Employee() { EmployeeID = 007, FirstName = "Jessie", LastName = "Cervantes" });
            employees.Add(new Employee() { EmployeeID = 008, FirstName = "Harry", LastName = "Potter" });
            employees.Add(new Employee() { EmployeeID = 009, FirstName = "Joe", LastName = "Macy" });
            employees.Add(new Employee() { EmployeeID = 010, FirstName = "Samantha", LastName = "Belcher" });
            employees.Add(new Employee() { EmployeeID = 011, FirstName = "Cortana", LastName = "Belcher" });
            employees.Add(new Employee() { EmployeeID = 012, FirstName = "Vincent", LastName = "LaClaire" });

            List<Employee> newList = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                }
            }    

            foreach (Employee joe1 in newList)
            {
                Console.WriteLine($"New list {joe1.EmployeeID} {joe1.FirstName} {joe1.LastName}\n");
            }

            List<Employee> joeList = employees.Where(f => f.FirstName == "Joe").ToList();
            List<Employee> newList1 = employees.Where(i => i.EmployeeID > 005).ToList();

            foreach (Employee emp in joeList)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.FirstName} {emp.LastName}\n");
            }

            foreach (Employee joe in newList1)
            {
                Console.WriteLine($"{joe.EmployeeID} {joe.FirstName} {joe.LastName}");
            }

            Console.ReadLine();

        }
    }
}
