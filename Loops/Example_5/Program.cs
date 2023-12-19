//////////////////
// Break a loop //
//////////////////

using System;
using System.Runtime.InteropServices;

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
*/