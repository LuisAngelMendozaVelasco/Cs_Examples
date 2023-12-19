///////////////////////////////////////////////////////////////////
// Use the Substring() method together with the IndexOf() method //
///////////////////////////////////////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace GetLastName
{
    class Program
    {
        static void Main()
        {
            // Full name
            string name = "Luis Mendoza";

            // Location of the letter D
            int charPos = name.IndexOf("M");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);

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

Mendoza
*/