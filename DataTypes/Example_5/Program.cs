//Create a double type

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double myNum = 19.99D;
            
            Console.WriteLine(myNum);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}