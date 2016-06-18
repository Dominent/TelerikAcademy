using System;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            ulong input = Convert.ToUInt64(Console.ReadLine());
            ulong mask = 1;

            Console.WriteLine("{0}", ((input & (mask << 3)) == 0)? 0 : 1);
        }
    }
}
