//Single-line comment at the end of a line of code

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  // This is a comment   
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);    
        }
    }
}