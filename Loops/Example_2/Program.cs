///////////////////
// Do while loop //
///////////////////

using System;
using System.Runtime.InteropServices;

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

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.Write($"{Environment.NewLine}Press any key to exit...");
                Console.ReadKey(true); 
            }          
        }
    }
}

/*
Output:

0
1
2
3
4
*/