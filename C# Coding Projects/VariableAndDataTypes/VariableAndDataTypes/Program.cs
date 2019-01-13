using System;

namespace VariableAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();


            // Data Types

            bool isStudyig = false; //Boolean
            byte hoursWorked = 42; // Number 0-255
            sbyte currentTemp = -23; // negative and positive number

            // Can use unicode to create characters
            char randomLetter = 'X'; 
            char questionMark = '\u2103';

            //For finances
            decimal monoeyInBank = 100.5m;

            //For numbers 15 or 16 digits in length especially in decimals
            double heightInCentimeters = 211.2343462;

            //For numbers up to 7 digits
            float secondsLeft = 2.62f;

            //For whole numbers in general
            int newAge = 21;

            //For smaller whole numbers
            short tempOnMars = -341;

            //To write out words
            string myName = "Ryan";

            //Types of casts (changing from one data type to another)
            int currentAge = 46;
            string yearsOld = currentAge.ToString(); //Converts int to string

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);




            Console.WriteLine(isRaining+" it is raining.");
            Console.ReadLine();
        }
    }
}
