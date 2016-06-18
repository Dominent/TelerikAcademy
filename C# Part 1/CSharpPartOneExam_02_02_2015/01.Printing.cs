using System;

namespace Printing
{
    class Printing
    {
        static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());
            int valS = Convert.ToInt32(Console.ReadLine());
            decimal realm = 500.0m;
            decimal valP = Convert.ToDecimal(Console.ReadLine());

            decimal money = (((valN * valS) / realm)) * valP;

            Console.WriteLine("{0:F2}", money);

        }
    }
}
