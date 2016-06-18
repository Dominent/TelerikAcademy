using System;

namespace Interval
{
    class Interval
    {
        static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());
            int valM = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = valN + 1; i < valM; i++)
            {
                if (i % 5 == 0) ++count;
            }

            Console.WriteLine(count);

        }
    }
}
