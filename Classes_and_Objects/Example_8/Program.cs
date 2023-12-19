//////////////////////////////
// Properties (get and set) //
//////////////////////////////

/*
The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
* declare fields/variables as private.
* provide public get and set methods, through properties, to access and update the value of a private field.
A property is like a combination of a variable and a method, and it has two methods: a get and a set method.
*/

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