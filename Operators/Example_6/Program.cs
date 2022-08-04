//Increment operator

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            x++;
            Console.WriteLine(x);  
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}