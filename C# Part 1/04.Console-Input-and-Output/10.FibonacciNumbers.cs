using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            for (ulong i = 0, k = 1, j = 0; j < (ulong)input; ++j)
            {
                ulong temp = i;

                if ((int)j == input - 1)
                    Console.Write("{0}", i);
                else
                    Console.Write("{0}, ", i);

                i += k;
                k = temp;
            }
        }
    }
}
