//Access fields and methods

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();

            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;
            Console.WriteLine(Ford.model);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);
            Ford.fullThrottle();

            Console.Write($"{Environment.NewLine}");
    
            Car Opel = new Car();

            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;
    
            Console.WriteLine(Opel.model);
            Console.WriteLine(Opel.color);
            Console.WriteLine(Opel.year);
            Opel.fullThrottle();

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}