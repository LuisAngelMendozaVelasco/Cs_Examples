//Single-line comment before a line of code

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment
            Console.WriteLine("Hello World!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);     
        }
    }
}