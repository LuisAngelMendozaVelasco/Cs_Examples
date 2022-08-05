//String concatenation with the Concat() method

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Luis ";
            string lastName = "Mendoza";
            string name = string.Concat(firstName, lastName);

            Console.WriteLine(name);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}