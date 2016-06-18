using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());
            int valK = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0}", Factorial(valN) / Factorial(valK));
        }

        private static BigInteger Factorial(int input)
        {
            if (input == 0) return 1;
            return input * Factorial(input - 1);
        }
    }
}
