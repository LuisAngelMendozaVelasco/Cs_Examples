//Use quotes in a string

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "We are the so-called \"Vikings\" from the north.";

            Console.WriteLine(txt);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}