using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            //      Adding variables
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.WriteLine("Fifteen plus Thirty Four = " + combined.ToString());
            Console.ReadLine();


            //      Subtracting Variables
            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());
            Console.ReadLine();


            //      Multiplying
            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();


            //      Dividing
            int quotient = 10 / 5;
            Console.WriteLine(quotient);    //  Since integers are whole numbers, if the answer has a decimal, then C# will round the number down. It drops the decimal.
            Console.ReadLine();

            double quotient2 = 100.0 / 17.0;
            Console.WriteLine(quotient2);   //  This will return the accurate value, but numbers (100.0 & 17.0) must have decimals for it to work.
            Console.ReadLine();



            //      Remainder   Used fairly often. An example would be making an operation occur every other time it's run.
            int remainder = 10 % 2; //  Where % is called modulus.
            Console.WriteLine(remainder);
            Console.ReadLine();

            int remainder = 15 % 2;
            Console.WriteLine(remainder);   //      The answer will always be either 0 or 1. 0 = Even, 1 = Odd.
            Console.ReadLine();



            //      Comparison Operators    =   Boolean (bool)  =   True or False
            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse.ToString());  //  This is True
            Console.ReadLine();

            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse.ToString());  //  This is False
            Console.ReadLine();


            ////      Boolean Logic used with "AND" (&&) and "OR" (||)and "NOT"
            //[6 > 3] AND [22 <= 23] //   Looking for both to be true

            //[6 > 3] OR [22 <= 23] //    Looking for either one to be true
            ////      This can be done with multiple equations


            int packageHeight = 25;
            int packageWidth = 10;

            bool tooBig = (packageHeight > 25 && packageWidth > 25);

            Console.WriteLine(tooBig);     //  This would be false



            int packageHeight = 25;
            int packageWidth = 10;

            bool tooBig = (packageHeight > 24 || packageWidth > 25);

            Console.WriteLine(tooBig);     //     This would be true as it's either or



            string firstName = "Jesse";
            string lastName = "Johnson";
            string socialSecurityNumber = "111-11-1111";

            bool isAuthorized = (firstName == "Jesse" && lastName == "Johnson" && socialSecurityNumber == "111-11-1111");

            Console.WriteLine(isAuthorized);

            Console.ReadLine(); //  True


            int bankAccountBalance = 500;
            bool isInARockBand = false;
            string firstName = "Jesse";

            bool isReallyCool = (bankAccountBalance > 10000 || isInARockBand || firstName == "Jesse");

            Console.WriteLine(isReallyCool);
            Console.ReadLine(); //  True because at least one of them is true


            //      Both && and || can be used in one line

            bool result = (true && (true || false));


           

        }
    }
}
