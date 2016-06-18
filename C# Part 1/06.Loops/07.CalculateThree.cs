using System;
using System.Numerics;

namespace CalculateThree
{
    class CalculateThree
    {
        static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());
            int valK = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", Factorial(valN) / (Factorial(valK) * Factorial(valN - valK)));
        }

        private static BigInteger Factorial(int input)
        {
            if (input == 0) return 1;
            return input * Factorial(input - 1);
        }
    }
}
