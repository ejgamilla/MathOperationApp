using System;

namespace MathApp
{
    // This class contains mathematical operations
    public class MathOperations
    {
        // This method takes two integers, adds 10 to the first integer, and displays the second integer
        public void Operate(int num1, int num2)
        {
            int result = num1 + 10; // Perform a math operation on the first integer
            Console.WriteLine($"Result after adding 10 to {num1} is {result} and the second integer is {num2}"); // Display the result and the second integer
        }
    }
}
