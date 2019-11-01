using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 2;

            Console.WriteLine(Multiply(a, b).ToString());
            Console.WriteLine(Divide(a, b).ToString());
            Console.ReadKey();
        }

        private static int Multiply(int a, int b)
        {
            // Implement the method to multiply a with b without using the multiplication operator (*)
            // the expected result should is 8 given a = 4 and b = 2
            throw new NotImplementedException();
        }

        private static int Divide(int a, int b)
        {
            // Implement the method to divide a with b without using the division operator (/)
            // the expected result should is 2 given a = 4 and b = 2

            throw new NotImplementedException();
        }
    }
}
