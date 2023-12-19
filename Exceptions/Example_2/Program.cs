///////////////////////////
// The finally statement //
///////////////////////////

using System;
using System.Runtime.InteropServices;

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
            catch(Exception)
            {
                Console.WriteLine("Something went wrong!");
            }  
            finally
            {
                Console.WriteLine("The 'try catch' is finished!");
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

Something went wrong!
The 'try catch' is finished!
*/