//Return the sum of a method's two parameters

using System;

namespace MyApplication
{
    class Program
    {
        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int z = MyMethod(5, 3);

            Console.WriteLine(z);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}