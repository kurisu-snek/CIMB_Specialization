using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sesi3.assignment1
{
    public class factorial
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is {factorial}");
        }

        // Function to calculate the factorial of a number.
        // Takes an integer as input and returns the factorial as an integer.
        private static int CalculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}
