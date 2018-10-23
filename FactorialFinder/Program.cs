using System;

namespace FactorialFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to find the Factorial of it");
            long factorialNumber = Convert.ToInt32(Console.ReadLine());

            long factorialCalculated = factorial(factorialNumber + 1) / (factorialNumber + 1);

            Console.WriteLine("The factorial is: " + factorialCalculated); // 39! equals int Overflow
            Console.ReadKey();
        }
        static long factorial(long value)
        {
            long factorialCalculated;

            if (value != 0)
            {
                factorialCalculated = 1;
                for (int i = 0; i < value; i++)
                {
                    factorialCalculated = (value - i) * factorialCalculated;
                }
            }
            else
            {
                factorialCalculated = 1;
            }

            return factorialCalculated;
        }
    }
}