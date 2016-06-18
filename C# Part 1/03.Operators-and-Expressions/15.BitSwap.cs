using System;

namespace BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            ulong input = Convert.ToUInt64(Console.ReadLine());
            int startSeqPos = Convert.ToInt32(Console.ReadLine());
            int endSeqPos = Convert.ToInt32(Console.ReadLine());
            int length = Convert.ToInt32(Console.ReadLine());

            ulong mask = 1UL;

            for (int i = 0; i < length; i++)
            {
                input = ExchangeBit(input, startSeqPos + i, endSeqPos + i);
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
                number = number ^ (mask << bitPos);

            return number;
        }
    }
}
