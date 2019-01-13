using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextWritingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            string num = Console.ReadLine();
            File.WriteAllText(@"C:\Users\ryanl\Logs\user.txt", num);
            string text = File.ReadAllText(@"C:\Users\ryanl\Logs\user.txt");
            Console.WriteLine($"The contents of the file user.txt is: {text}");
            Console.ReadLine();
        }
    }
}
