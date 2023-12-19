///////////////////
// Sort an array //
///////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort a string
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            Array.Sort(cars);
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }    
            
            Console.Write($"{Environment.NewLine}");

            // Sort an int
            int[] myNumbers = {5, 1, 8, 9};

            Array.Sort(myNumbers);
            foreach(int i in myNumbers)
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

BMW
Ford
Mazda
Volvo

1
5
8
9
*/