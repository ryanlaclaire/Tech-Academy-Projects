﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);     // ^ = true if one of the choices is true, but not if both are true.
            //Console.WriteLine(true ^ false);    //  Known as the XOR operator
            //Console.WriteLine(false ^ false);

            Console.WriteLine(true && true && true && false);   //  False
            Console.WriteLine(true && true && true || false);   //  True

            Console.ReadLine();

        }
    }
}
