using System;

namespace TriangleSurfaceByThreeSides
{
    class TriangleSurfaceByThreeSides
    {
        static void Main()
        {
            double sideA = Convert.ToDouble(Console.ReadLine());
            double sideB = Convert.ToDouble(Console.ReadLine());
            double sideC = Convert.ToDouble(Console.ReadLine());

            double halfP = (sideA + sideB + sideC) / 2.0d;

            double temp = halfP * ((halfP - sideA) * (halfP - sideB) * (halfP - sideC));

            double area = Math.Sqrt(temp);

            Console.WriteLine("{0:F2}", area);
        }
    }
}
