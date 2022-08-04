//Multi-line comment

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The code below will print the words Hello World
            to the screen, and it is amazing */
            Console.WriteLine("Hello World!");  
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);    
        }
    }
}