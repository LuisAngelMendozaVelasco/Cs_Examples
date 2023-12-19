﻿//////////////////////
// Implicit casting //
//////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 9;
            double myDouble = myInt;  // Automatic casting: int to double

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.Write($"{Environment.NewLine}Press any key to exit...");
                Console.ReadKey(true); 
            }          
        }
    }
}

/*
Output:

9
9
*/