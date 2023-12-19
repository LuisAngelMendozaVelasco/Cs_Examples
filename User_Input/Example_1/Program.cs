﻿/////////////////////////
// Get user input text //
/////////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string? userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("\nUsername is: " + userName);
            
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

Enter username:
Luis

Username is: Luis
*/