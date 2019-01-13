using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Simple if else statement which writes out the first line
            if (1 == 1)
            {
                Console.WriteLine("1 equals 1!");
            }
            else
            {
                Console.WriteLine("1 does not equal 1");    //  If statements do not need to be followed by else statements, but they can.
            }


            //      This if else statement gives out the else command
            string name = "Brett";

            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse");
            }


            //      This is a if/elseif/else which (in this case) gives out the else command
            string firstName = "Adam";

            if (firstName =="Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (firstName == "Brett")
            {
                Console.WriteLine("Your name is Brett");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse and your name is not Brett");
            }


            //      You don't always have to put an else at the end. This is run until one of these coditions is met and the rest are then skipped.
            string newName = "Erik";

            if (newName == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (newName == "Brett")
            {
                Console.WriteLine("Your name is Brett");
            }
            else if (newName == "Adam")
            {
                Console.WriteLine("Your name is Adam");
            }


            //      You can also use other comparison operators in the same way.
            string anotherName = "Brett";

            if (anotherName != "Jesse")
            {
                Console.WriteLine("Your name is not Jesse");
            }


            //      Another example
            if (1 != 2)
            {
                Console.WriteLine("All is right with the universe.");
            }
            else
            {
                Console.WriteLine("We live in bizarro world.");
            }


            //      Using greater than
            if (2 > 1)
            {
                Console.WriteLine("Two is greater than one.");
            }
            else
            {
                Console.WriteLine("Something is severely wrong if this prints to the console.");
            }


            //      Using less than
            int age = 19;

            if (age < 21)
            {
                Console.WriteLine("No you may not purchase that bottle of wine.");
            }
            else
            {
                Console.WriteLine("That will be $21.40");
            }

            //      Less than or equals to
            int newAge = 20;

            if(newAge <= 20)
            {
                Console.WriteLine("You may not purchase that bottle of wine.");
            }
            else
            {
                Console.WriteLine("There you go.");
            }


            //      Using greater than
            if (age >= 25)
            {
                Console.WriteLine("Yes you may rent a car from us.");
            }
            else
            {
                Console.WriteLine("No you may not rent a car from us.");
            }

            //      Using the && operator
            if (1==1 && 5 == 5)
            {
                Console.WriteLine("All is right with the world.");
            }

            if (true && true && true)
            {
                Console.WriteLine("Everything is true.");
            }

            //      Real life example
            int packageWeight = 50;
            int packageHeight = 25;

            if (packageWeight > 40 && packageHeight > 20)
            {
                Console.WriteLine("All is true!");
            }
            else
            {
                Console.WriteLine("This package is too big to ship.");
            }

            //      ||(OR) can be use the same way
            string role = "admin";

            if (role == "admin" || role == "administrator")
            {
                Console.WriteLine("You may have access to the entire software system.");
            }


            //      Turnary operator - uses 3 arguments. Basically creates a if/else statement in one line.
            int currentTemp = 80;
            int roomTemp = 70;

            string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";

            Console.WriteLine(comparisonResult);
            Console.ReadLine();


            //      Writing a basic program based on user input
            int roomTemperature = 70;

            Console.WriteLine("Hi, what is your name?");
            string currentName = Console.ReadLine();

            Console.WriteLine($"Hi, {currentName}, what is the temperature where you are?");
            int getTemp = Convert.ToInt32(Console.ReadLine());

            if (getTemp == roomTemperature)
            {
                Console.WriteLine($"It is exactly {roomTemperature} degrees.");
            }
            else if (getTemp > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (getTemp < roomTemperature)
            {
                Console.WriteLine("It is colder than room temperature.");
            }
            else
            {
                Console.WriteLine("Uhhhhhh....somethig went wrong.");
            }


            //      Another basic using a turnary (^)
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string results = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";

            Console.WriteLine(results);
            Console.ReadLine();

        }
    }
}
