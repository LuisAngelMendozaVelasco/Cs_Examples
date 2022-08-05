//Loop through an array with foreach

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            foreach(string i in cars) 
            {
                Console.WriteLine(i);
            }   
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true); 
        }
    }
}