//Create a long type

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            long myNum = 15000000000L;

            Console.WriteLine(myNum);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}