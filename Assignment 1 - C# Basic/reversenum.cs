using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sesi3.assignment1
{
    public class reversenum
    {
        
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = ReverseNumber(number);

            Console.WriteLine($"The reversed number is: {reversedNumber}");
        }

        private static int ReverseNumber(int number)
        {
            int reversedNumber = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            return reversedNumber;
        }
    }
}