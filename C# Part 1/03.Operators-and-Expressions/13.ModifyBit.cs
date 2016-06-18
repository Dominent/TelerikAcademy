using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong input = Convert.ToUInt64(Console.ReadLine());
            byte valP = Convert.ToByte(Console.ReadLine());
            byte valV = Convert.ToByte(Console.ReadLine());
            
            ulong mask = 1UL;

            if (valV == 1) input = input | (mask << valP);
            else input = (((input & (mask << valP)) == 0) ? 0 : 1) == 1 ? input ^ (mask << valP) : input;

            Console.WriteLine(input);
        }
    }
}
