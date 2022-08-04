//Create a float type

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            float myNum = 5.75F;

            Console.WriteLine(myNum);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}