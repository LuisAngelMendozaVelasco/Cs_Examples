//Method with parameters

using System;

namespace MyApplication
{
    class Program
    {
        static void MyMethod(string fname) 
        {
            Console.WriteLine(fname + " Refsnes");
        }

        static void Main(string[] args)
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }  
    }
}