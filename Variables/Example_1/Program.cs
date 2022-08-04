//Create a string variable

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            
            Console.WriteLine(name);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);             
        }
    }
}