using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            bool isPrime = (input <= 1 ? false : true);

            for (int i = 2; i <= Math.Sqrt(input); i++)
                if (input % i == 0)
                    isPrime = false;

            Console.WriteLine("{0}", isPrime ? "true" : "false");
        }
    }
}
