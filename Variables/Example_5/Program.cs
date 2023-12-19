////////////////////////////////////////////
// Combine text and a variable on display //
////////////////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
  class Program
    {
        static void Main(string[] args)
        {
            string name = "Luis";
            Console.WriteLine("Hello " + name);

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

Hello Luis
*/