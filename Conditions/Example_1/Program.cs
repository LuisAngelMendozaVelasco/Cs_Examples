//The if statement

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if(20 > 18) 
            {
                Console.WriteLine("20 is greater than 18");
            }
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);    
        }
    }
}