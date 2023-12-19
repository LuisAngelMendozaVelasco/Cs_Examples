﻿///////////////////////
// Using System.Linq //
///////////////////////

using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = {5, 1, 8, 9};

            Console.WriteLine(myNumbers.Max());  // largest value
            Console.WriteLine(myNumbers.Min());  // smallest value
            Console.WriteLine(myNumbers.Sum());  // sum of myNumbers

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
1
23
*/