//Create and access an array

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            Console.WriteLine(cars[0]);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true); 
        }
    }
}