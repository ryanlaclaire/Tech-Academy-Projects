using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strType = new Employee<string>();
            Employee<int> numType = new Employee<int>();
            strType.Things = new List<string>();
            numType.Things = new List<int>();


            strType.Things.Add("This");
            strType.Things.Add("is");
            strType.Things.Add("Interesting.");

            numType.Things.Add(27);
            numType.Things.Add(34);
            numType.Things.Add(52);


            foreach (string s1 in strType.Things)
            {
                Console.WriteLine(s1);
            }
            foreach (int n1 in numType.Things)
            {
               Console.WriteLine(n1);
            }

            Console.ReadLine();

        }
    }
}
