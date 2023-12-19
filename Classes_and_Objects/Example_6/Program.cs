//////////////////////
// Private modifier //
//////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Car
    {
        private string model = "Mustang"; // The code is only accessible within the same class

        static void Main(string[] args)
        {
            Car myObj = new Car();

            Console.WriteLine(myObj.model);
            
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

Mustang
*/