////////////////////////
// Multi-line comment //
////////////////////////

using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            The code below will print the words Hello World
            to the screen, and it is amazing 
            */
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