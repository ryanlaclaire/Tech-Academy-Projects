using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Using for loops use little space
            //          Using an integer array
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)     //      Creating a for loop requires 3 values. What you are looking for, how long it will run, and what to do at the end
            //{
            //    if (testScores[i] > 85)                                         //      The [i] is a variable to allow us to scan the array
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //      Using a string array
            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();


            ////      Simply writing the array to the console

            //string[] names1 = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names1.Length; j++)
            //{
            //    Console.WriteLine(names1[j]);
            //}
            //Console.ReadLine();


            ////          Creating a list or importing a list will give you lots of data to work with

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);
            //testScores.Add(65);
            //testScores.Add(77);

            //foreach (int score in testScores)           //          The for each loop will scan through the list. Does not work with an array
            //{
            //    if (score > 70)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();


            List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            foreach (string name in names)
            {
                if (name == "Erik")                    //          Will print out one name
                {
                    Console.WriteLine(name);
                }
            }
            Console.ReadLine();


            //List<string> names1 = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names1)
            //{


            //    Console.WriteLine(name);                //          Will print out all names

            //}
            //Console.ReadLine();


            ////              This is to check a list, find data you want and add that data to another list

            //List<int> testScores = new List<int> { 98, 99, 12, 74, 23, 99 };
            //List<int> passingScores = new List<int>();                              //          Creates a blank list. Cannot do this with an array


            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
            //Console.WriteLine(passingScores.Count);                                 // .Count works for lists whereas .Length is for Arrays
            //Console.ReadLine();



            //      Iteration Exercises

            //      Step 1
            string[] towns = { "Portland - ", "Tampa - ", "Pheonix - ", "Seattle - ", "New York - " };
            Console.WriteLine("Please input some text to add to the array (towns):");
            string newTown = Console.ReadLine();

            for (int i = 0; i < towns.Length ; i++)
            {
                towns[i] += newTown;
                Console.WriteLine(towns[i]);
                
            }
            Console.ReadLine();

            //      Step 2
            //while (true)
            //{

            //}

            //      Step 3
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.ReadLine();

            //      Step 4
            for (int j = 0; j < towns.Length; j++)
            {
                Console.WriteLine($"These are interesting towns: {towns[j]}");
            }
            Console.ReadLine();

            //      Step 5
            List<int> testScores = new List<int> { 98, 99, 12, 74, 23, 99 };
            
            foreach (int score in testScores)
            {
                if (score <= 75)
                {
                    Console.WriteLine($"Sorry, {score} is not a passing grade.");
                }
            }
            
            Console.ReadLine();

            //List<string> names1 = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //      Step 6
            List<string> countries = new List<string>() { "USA", "Canada", "Mexico", "England", "France", "Germany", "Italy", "Spain", "Greece" };
            Console.WriteLine("Please select a country to search for: \nYour choices are: USA, Canada, Mexico, England, France, Germany, Italy, Spain or Greece");
            string choice = Console.ReadLine();
            bool correctChoice = false;

            foreach (string country in countries)
            {
                if (country == choice)
                {
                    Console.WriteLine($"You chose {country}");
                    correctChoice = true;
                    break;                                                  //  Step 8
                }
            }


            if (correctChoice == false)
            {
                Console.WriteLine($"Sorry, {choice} is either not in the list or is not spelled correctly.");     //  Step 7
            }
            Console.ReadLine();


            //      Step 9
            List<string> compBrands = new List<string>() { "Asus", "Dell", "MSI", "Mac", "Asus", "MSI" };
            Console.WriteLine("Please select one of the following popular brands of computers from the list. \nChoices include: Asus, Dell, MSI or Mac");
            string brandChoice = Console.ReadLine();
            bool rightBrand = false;

            foreach (string brand in compBrands)
            {
                if (brand == brandChoice)
                {
                    Console.WriteLine($"{brand} is a great choice.");
                    rightBrand = true;
                    break;
                }
            }

            if (rightBrand == false)
            {
                Console.WriteLine($"Sorry, {brandChoice} doesn't appear to be on the list.");      //  Step 10
            }
            Console.ReadLine();


            // Step 11
            List<string> videoGames = new List<string>() { "Halo", "Halo", "Darksiders II", "Destiny II", "Grand Theft Auto", "Destiny II", "WarCraft", "Dishonored", "Darksiders II" };
            List<string> singleGames = new List<string>();

            foreach (string game in videoGames)
            {
                if (!singleGames.Contains(game))
                {
                    singleGames.Add(game);
                    Console.WriteLine($"{game}");
                }
                else
                {
                    Console.WriteLine($"{game} - duplicate");
                }
            }
            Console.ReadLine();


        }
    }
}
