//////////////////////////////////////////////////////
// Single-line comment at the end of a line of code //
//////////////////////////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  // This is a comment   
            
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