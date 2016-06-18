using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}",
                Factorial(2 * valN) / (Factorial(valN + 1) * Factorial(valN)));
        }

        private static BigInteger Factorial(int input)
        {
            if (input == 0) return 1;
            return input * Factorial(input - 1);
        }
    }
}
