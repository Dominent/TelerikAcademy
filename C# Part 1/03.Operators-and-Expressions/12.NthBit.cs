using System;

namespace NthBit
{
    class NthBit
    {
        static void Main()
        {
            ulong input = Convert.ToUInt64(Console.ReadLine());
            byte valN = Convert.ToByte(Console.ReadLine());
            ulong mask = 1UL;

            Console.WriteLine("{0}", ((input & (mask << valN)) == 0) ? 0 : 1);
        }
    }
}
