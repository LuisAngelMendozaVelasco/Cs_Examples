/////////////////////////////////
// Get user input with numbers //
/////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour age is: " + age);

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

Enter your age: 
29

Your age is: 29
*/