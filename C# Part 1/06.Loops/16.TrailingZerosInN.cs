using System;

namespace TrailingZerosInN
{
    class TrailingZerosInN
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int pow = 0;
            int trailingZeros = 0;

            for (int i = 1; i <= input; i++)
                if (Math.Pow(5, i) > input) pow = i;
            for (int i = 1; i <= pow; i++)
                trailingZeros += input / (int)Math.Pow(5, i);

            Console.WriteLine(trailingZeros);
        }
    }
}
