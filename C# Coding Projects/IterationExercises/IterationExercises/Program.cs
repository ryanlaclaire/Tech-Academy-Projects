using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Iteration Exercises

            //      Step 1
            string[] towns = { "Portland - ", "Tampa - ", "Pheonix - ", "Seattle - ", "New York - " };
            Console.WriteLine("Please input some text to add to the array (towns):");
            string newTown = Console.ReadLine();

            for (int i = 0; i < towns.Length; i++)
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
