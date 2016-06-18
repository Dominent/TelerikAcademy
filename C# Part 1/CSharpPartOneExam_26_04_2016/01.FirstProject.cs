using System;
using System.Numerics;

namespace FirstProject
{
    class FirstProject
    {
        static void Main()
        {
            ulong valT = Convert.ToUInt64(Console.ReadLine());
            ulong valB = Convert.ToUInt64(Console.ReadLine());
            ulong valS = Convert.ToUInt64(Console.ReadLine());
            ulong valN = Convert.ToUInt64(Console.ReadLine());

            ulong result = valT * valB * valS * valN;

            double output = result / 7.0d;

            if (result % 2 == 0)
                Console.WriteLine("{0:F3}", result * 376439.0d);
            else
                Console.WriteLine("{0:F3}", output);
        }

    }
}


