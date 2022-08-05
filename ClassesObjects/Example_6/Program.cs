//Private modifier

using System;

namespace MyApplication
{
    class Car
    {
        private string model = "Mustang"; // The code is only accessible within the same class

        static void Main(string[] args)
        {
            Car myObj = new Car();

            Console.WriteLine(myObj.model);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}