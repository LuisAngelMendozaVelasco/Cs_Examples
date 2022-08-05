//Use the "equal to" operator to evaluate a boolean expression

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            
            Console.WriteLine(x == 10); // returns True, because the value of x is equal to 10
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}