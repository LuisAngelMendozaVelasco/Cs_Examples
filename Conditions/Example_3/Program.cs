///////////////////////////
// The else if statement //
///////////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 22;

            if (time < 10) 
            {
                Console.WriteLine("Good morning!");
            } 
            else if (time < 20) 
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