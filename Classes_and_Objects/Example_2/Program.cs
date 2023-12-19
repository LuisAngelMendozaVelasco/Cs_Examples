////////////////////////////////////////
// Create multiple objects of a class //
////////////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();

            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);

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

red
red
*/