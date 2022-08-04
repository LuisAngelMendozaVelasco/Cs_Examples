//Combine text and a variable on display

using System;

namespace MyApplication
{
  class Program
    {
        static void Main(string[] args)
        {
            string name = "Luis";

            Console.WriteLine("Hello " + name);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}