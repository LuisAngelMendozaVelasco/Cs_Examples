//Find out if an expression is true or false

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 9;
            
            Console.WriteLine(x > y); // returns True, because 10 is higher than 9
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}