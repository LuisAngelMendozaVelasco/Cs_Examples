//Create an int type

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 100000;

            Console.WriteLine(myNum);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}