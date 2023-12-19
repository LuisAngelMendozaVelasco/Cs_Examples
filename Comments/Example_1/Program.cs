///////////////////////////////////////////////
// Single-line comment before a line of code //
///////////////////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment
            Console.WriteLine("Hello World!");
            
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

Hello World!
*/