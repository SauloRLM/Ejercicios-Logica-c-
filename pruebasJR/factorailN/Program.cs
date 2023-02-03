
using System;
using System.Numerics;

namespace FactorialExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }else{
            
                BigInteger result = 1;

                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                Console.WriteLine("The factorial of " + number + " is " + result.ToString());
            }            
        }
    }
}