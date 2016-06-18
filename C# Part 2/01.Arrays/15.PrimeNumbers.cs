using System;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SieveOfEratosthenes(input));
        }

        static int SieveOfEratosthenes(int input)
        {
            int maxPrime = 0;
            bool[] isPrime = new bool[input];

            for (int i = 1; i < isPrime.Length; i++)
                isPrime[i] = true;

            for (int i = 2; i <= isPrime.Length; i++)
                if (isPrime[i - 1])
                {
                    if (i > maxPrime)
                        maxPrime = i;
                    for (int j = i * 2; j <= isPrime.Length; j += i)
                        isPrime[j - 1] = false;
                }

            return maxPrime;
        }
    }
}
