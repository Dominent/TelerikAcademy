using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            Console.WriteLine(Factorial(Convert.ToInt32(Console.ReadLine())));
        }

        static BigInteger Factorial(int valN)
        {
            if (valN == 0)
                return 1;

            return valN * Factorial(valN - 1);
        }
    }
}
