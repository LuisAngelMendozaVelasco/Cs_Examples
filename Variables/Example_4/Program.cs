//Overwrite an existing variable value

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 15;
            
            myNum = 20;
            Console.WriteLine(myNum);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}