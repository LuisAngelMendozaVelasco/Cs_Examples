//Create a bool type

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCSharpFun = true;
            bool isFishTasty = false;

            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False 
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);   
        }
    }
}