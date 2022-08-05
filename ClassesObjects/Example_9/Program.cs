//Automatic (short-hand) properties

using System;

namespace MyApplication
{
    class Program
    {  
        static void Main(string[] args)
        {
            Person myObj = new Person();

            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}