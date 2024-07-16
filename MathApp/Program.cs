using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the Operate method with two numbers
            mathOperations.Operate(5, 20);

            // Call the Operate method, specifying the parameters by name
            mathOperations.Operate(num1: 10, num2: 30);

            // Prevent the console from closing immediately
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
