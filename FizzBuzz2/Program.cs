using System;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i} {FizzBuzz(i)}");
            }

            Console.ReadKey();
        }

        static string FizzBuzz(int a)
        {
            // implement the method to print Fizz, Buzz, FizzBuzz or the value of a. See README.md for the rules
            throw new NotImplementedException();
        }
    }
}
