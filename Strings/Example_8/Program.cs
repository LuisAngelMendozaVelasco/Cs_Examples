//Find the index position of a specific character in a string, by using the IndexOf() method

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello";

            Console.WriteLine(myString.IndexOf("e"));
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}