using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Exercise for step 100

            string[] firstName = { "Ryan", "Jon", "Abbie", "Perry", "Belinda" };
            int[] intNum = { 5, 11, 90, 635, 2, 5500, 6003 };
            List<string> lastName = new List<string>(new string[] { "Smith", "Jones", "LaClaire", "Wilson", "Carlisle" });
            int string1;
            int num1;
            int string2;



            Console.WriteLine("Please select an Index of array firstName to display. Choices are 0, 1, 2, 3 or 4:");
            string input1 = Console.ReadLine();
            int.TryParse(input1, out string1);
            if (string1 <= 4)
            {
                Console.WriteLine($"The name at index {string1} is {firstName[string1]}");
            }
            else
            {
                Console.WriteLine("Sorry, that's not a valid choice.");
            }

            Console.WriteLine("Please select an Index of array intNum to display. Choices are 0, 1, 2, 3, 4, 5 or 6:");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out num1);

            if (num1 <= 6)
            {
                Console.WriteLine($"The number at index {num1} is {intNum[num1]}");
            }
            else
            {
                Console.WriteLine("Sorry, that's not a valid choice.");
            }

            Console.WriteLine("Please select an Index of array lastName to display. Choices are 0, 1, 2, 3 or 4:");
            string input3 = Console.ReadLine();
            int.TryParse(input3, out string2);

            if (string2 <= 4)
            {
                Console.WriteLine($"The Last Name at index {string2} is {lastName[string2]}");
            }
            else
            {
                Console.WriteLine("Sorry, that's not a valid choice.");
            }

            Console.ReadLine();
        }
    }
}
