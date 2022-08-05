//String concatenation

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Luis ";
            string lastName = "Mendoza";
            string name = firstName + lastName;

            Console.WriteLine(name);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}