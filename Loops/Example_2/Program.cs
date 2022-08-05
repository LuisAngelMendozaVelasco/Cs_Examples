//Do while loop

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do 
            {
                Console.WriteLine(i);
                i++;
            }
            while(i < 5);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}