//Create a char type

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            char myGrade = 'B';

            Console.WriteLine(myGrade);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true); 
        }
    }
}