//Using methods to convert strings to uppercase and lowercase

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Hello World";

            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}