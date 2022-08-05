//Use multiple classes for better organization

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            
            Console.WriteLine(myObj.color);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}