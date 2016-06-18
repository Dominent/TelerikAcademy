using System;

namespace BitsToBits
{
    class BitsToBits
    {
        static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());

            int zeroCount = 0;
            int maxZeroCount = 0;

            int oneCount = 0;
            int maxOneCount = 0;

            ulong lastBit = 9UL;

            for (int i = 0; i < valN; i++)
            {
                ulong input = Convert.ToUInt64(Console.ReadLine());

                for (int j = 29; j >= 0; j--)
                {
                    ulong bit = (((1UL << j) & input) >> j);

                    if (bit == 1)
                    {
                        if (lastBit == 1)
                            oneCount++;
                        else //lastBit == 0
                        {
                            maxZeroCount = Math.Max(maxZeroCount, zeroCount);
                            oneCount = 1;
                            zeroCount = 0;
                        }
                    }
                    else // bit == 0
                    {
                        if (lastBit == 0)
                            zeroCount++;
                        else //lastBit == 1
                        {
                            maxOneCount = Math.Max(maxOneCount, oneCount);
                            zeroCount = 1;
                            oneCount = 0;
                        }
                    }

                    lastBit = bit;
                    maxOneCount = Math.Max(maxOneCount, oneCount);
                    maxZeroCount = Math.Max(maxZeroCount, zeroCount);
                }
            }

            Console.WriteLine(maxZeroCount);
            Console.WriteLine(maxOneCount);

        }
    }
}
