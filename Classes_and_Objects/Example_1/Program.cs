/////////////////////////////////////////////
// Create a class and an object of a class //
/////////////////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            Car myObj = new Car(); // To create an object of Car, specify the class name, followed by the object name, and use the keyword new

            Console.WriteLine(myObj.color);

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
*/