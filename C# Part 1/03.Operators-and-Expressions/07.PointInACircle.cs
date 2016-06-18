using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            double valX = Convert.ToDouble(Console.ReadLine());
            double valY = Convert.ToDouble(Console.ReadLine());
            int radius = 2;

            double distance = Math.Sqrt(Math.Pow(valX, 2) + Math.Pow(valY, 2));

            Console.WriteLine("{0} {1:F2}", (distance <= radius ? "yes" : "no"), distance);
        }
    }
}
