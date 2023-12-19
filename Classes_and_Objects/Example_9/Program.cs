///////////////////////////////////////
// Automatic (short-hand) properties //
///////////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {  
        static void Main(string[] args)
        {
            Person myObj = new Person();

            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);

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

Liam
*/