using System;

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            ulong input = Convert.ToUInt64(Console.ReadLine());
            int[] atPos = { 3, 4, 5 };
            int[] toPos = { 24, 25, 26 };

            ulong mask = 1UL;

            for (int i = 0; i < 3; i++)
            {
                input = ExchangeBit(input, atPos[i], toPos[i]);
            }

            Console.WriteLine(input);
        }

        static int CheckBit(ulong number, int pos)
        {
            ulong mask = 1UL;
            return ((number & (mask << pos)) == 0) ? 0 : 1;
        }

        static ulong ExchangeBit(ulong number, int atPos, int toPos)
        {
            ulong mask = 1UL;

            int bitAtPos = CheckBit(number, atPos);
            int bitToPos = CheckBit(number, toPos);

            if (bitToPos != bitAtPos)
            {
                number = SetBit(number, bitAtPos, toPos);
                number = SetBit(number, bitToPos, atPos);
            }

            return number;
        }

        static ulong SetBit(ulong number, int bitVal, int bitPos)
        {
            ulong mask = 1UL;

            if (bitVal == 1)
                number = number | (mask << bitPos);
            else
                number = number ^(mask << bitPos);

            return number;
        }
    }
}
