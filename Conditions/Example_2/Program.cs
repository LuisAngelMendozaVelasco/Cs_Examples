////////////////////////
// The else statement //
////////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 20;

            if (time < 18) 
            {
                Console.WriteLine("Good day!");
            } 
            else 
            {
                Console.WriteLine("Good evening!");
            }

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

Good evening!
*/