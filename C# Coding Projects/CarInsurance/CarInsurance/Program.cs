using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            int currentAge;
            string input1 = Console.ReadLine();
            int.TryParse(input1, out currentAge);
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            string duiQuestion = Console.ReadLine();
            Boolean.TryParse(duiQuestion, out bool duiTrueFalse);
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTickets;
            string tickets = Console.ReadLine();
            int.TryParse(tickets, out speedTickets);
            Console.WriteLine("Qualified?");
            bool qualYes = currentAge > 15 && duiTrueFalse == false && speedTickets <= 3;
            if (qualYes == true)
            {
                Console.WriteLine(qualYes);
            }
            else
            {
                Console.WriteLine("Sorry, you're not approved");
            }
            Console.ReadLine();
        }
    }
}
