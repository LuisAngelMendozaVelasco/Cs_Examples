//The else statement

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 20;

            if (time < 18) 
            {
                Console.WriteLine("Good day.");
            } 
            else 
            {
                Console.WriteLine("Good evening.");
            }
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);  
        }
    }
}