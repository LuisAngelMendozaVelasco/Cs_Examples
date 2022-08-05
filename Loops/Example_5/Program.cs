//Break a loop

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++) 
            {
                if(i == 4) 
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);    
        }
    }
}