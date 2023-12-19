//////////////////////////
// String interpolation //
//////////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Luis";
            string lastName = "Mendoza";
            string name = $"My full name is: {firstName} {lastName}";

            Console.WriteLine(name);

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

My full name is: Luis Mendoza
*/