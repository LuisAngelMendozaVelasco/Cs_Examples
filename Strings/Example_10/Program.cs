////////////////////////////
// Use quotes in a string //
////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);

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

We are the so-called "Vikings" from the north.
*/