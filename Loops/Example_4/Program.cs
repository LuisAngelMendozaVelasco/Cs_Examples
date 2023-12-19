//////////////////
// Foreach loop //
//////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"}; // Declare a single-dimensional

            foreach(string i in cars) 
            {
                Console.WriteLine(i);
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

Volvo
BMW
Ford
Mazda
*/