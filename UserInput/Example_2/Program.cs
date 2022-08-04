//Get user input with numbers

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour age is: " + age);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}