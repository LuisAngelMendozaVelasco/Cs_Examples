//Declare many variables of the same type with a comma-separated list

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 6, z = 50;

            Console.WriteLine(x + y + z);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}