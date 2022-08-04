//Create a string type

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello World";

            Console.WriteLine(greeting);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true); 
        }
    }
}