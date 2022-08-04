//Create a variable without assigning the value, and assign the value later

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum;
            
            myNum = 15;
            Console.WriteLine(myNum);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);  
        }
    }
}