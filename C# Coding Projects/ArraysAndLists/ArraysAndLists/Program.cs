using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //      An array is a way to hold a group of variables. Usually a fixed quantity that won't change.
            //      Arrays are also used to store very large amounts of data.

            //int[] numArray = new int[5];        //      This instatiates a new array but you have to define the size of the array when it's created.
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;                   //      This is how to add data to the array
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };    //      This one line does exactly what the above 6 lines do.

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };              //      Even less code for the same thing.

            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[4]);     //      This will show the value of spot 4 in the array


            ////      Arrays are good but more commonly we will be using LISTS and this could be every day
            ////      Lists use System.Collections.Generic and can be used to create lists with any data type.

            //List<int> intList = new List<int>();                // Instantiates the list as an integer
            //List<string> stringList = new List<string>();       //  Instantiates the list as a string
            //stringList.Add("Hello Ryan.");
            //stringList.Add(" How are you?");

            //List<string> lastName = new List<string>(new string[] { "Smith", "Jones", "LaClaire", "Wilson", "Carlisle" });   //  Shortcut for creating a list

            //intList.Add(4);
            //intList.Add(10);                                    //  Adds data to the list

            //intList.Remove(10);                                 //  Removes data from list

            //Console.WriteLine(stringList[0] +stringList[1]);
            //Console.WriteLine(intList[0]);     //      This will show spot 0 of the List
            //Console.ReadLine();


            //      Exercise for step 100
            string[] firstName = { "Ryan", "Jon", "Abbie", "Perry", "Belinda" };
            int[] intNum = { 5, 11, 90, 635, 2, 5500, 6003 };
            List<string> lastName = new List<string>(new string[] {"Smith", "Jones", "LaClaire", "Wilson", "Carlisle"});
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
