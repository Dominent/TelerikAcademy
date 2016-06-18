using System;

namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static void Main()
        {
            double sideA = Convert.ToDouble(Console.ReadLine());
            double sideB = Convert.ToDouble(Console.ReadLine());
            double angle = Convert.ToDouble(Console.ReadLine());

            double radians = Math.PI / 180 * angle;

            double formula = (sideA * sideB * (Math.Sin(radians))) / 2; //* (Math.PI / 180) * Math.PI / 180)

            Console.WriteLine("{0:F2}", formula);
        }
    }
}
