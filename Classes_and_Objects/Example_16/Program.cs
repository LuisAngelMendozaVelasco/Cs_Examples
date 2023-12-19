////////////////////////
// Working with files //
////////////////////////

using System;
using System.IO;  // include the System.IO namespace
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string

            File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file

            Console.WriteLine(readText); // Output the content

            File.Delete("filename.txt"); // Delete the file

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