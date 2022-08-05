//Enums

/*An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma
Enum is short for "enumerations", which means "specifically listed".

Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.*/

using System;

namespace MyApplication
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;

            Console.WriteLine(myVar);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}