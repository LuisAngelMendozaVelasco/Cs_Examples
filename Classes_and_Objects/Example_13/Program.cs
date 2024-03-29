﻿///////////////
// Interface //
///////////////

/*
Another way to achieve abstraction in C#, is with interfaces.
An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies).
By default, members of an interface are abstract and public.
*/

/*
Notes on Interfaces:
* Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class).
* Interface methods do not have a body - the body is provided by the "implement" class.
* On implementation of an interface, you must override all of its methods.
* Interfaces can contain properties and methods, but not fields/variables.
* Interface members are by default abstract and public.
* An interface cannot contain a constructor (as it cannot be used to create objects).

Why And When To Use Interfaces?
1) To achieve security - hide certain details and only show the important details of an object (interface).
2) C# does not support "multiple inheritance" (a class can only inherit from one base class). 
However, it can be achieved with interfaces, because the class can implement multiple interfaces. 
Note: To implement multiple interfaces, separate them with a comma.
*/

using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    // Interface
    interface IAnimal 
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal 
    {
        public void animalSound() 
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            Pig myPig = new Pig();  // Create a Pig object
            
            myPig.animalSound();

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

The pig says: wee wee
*/