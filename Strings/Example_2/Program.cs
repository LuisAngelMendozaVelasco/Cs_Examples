//Find the length of a string

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("The length of the txt string is: " + txt.Length);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}