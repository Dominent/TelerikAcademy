using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            double input = Convert.ToDouble(Console.ReadLine());
            double gOnMoon = 0.17d;
            Console.WriteLine("{0:F3}", (input * gOnMoon));
        }
    }
}
