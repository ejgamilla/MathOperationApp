using System;

namespace MathOperationApp
{
    // Define a class called MathOperations
    class MathOperations
    {
        // Define a void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation (e.g., addition) on the first integer and store the result
            int result = num1 + 10;

            // Display the second integer to the screen
            Console.WriteLine($"The result of adding 10 to the first number is: {result}");
            Console.WriteLine($"The second number is: {num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method in the class, passing in two numbers
            mathOps.PerformOperation(5, 20);

            // Call the method in the class, specifying the parameters by name
            mathOps.PerformOperation(num1: 10, num2: 30);

            // Prevent the console from closing immediately
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
