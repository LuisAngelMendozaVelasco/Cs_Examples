//The try..catch statement

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = {1, 2, 3};

                Console.WriteLine(myNumbers[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);    
        }
    }
}