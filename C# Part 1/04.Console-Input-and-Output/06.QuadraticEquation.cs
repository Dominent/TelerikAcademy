using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double valA = Convert.ToDouble(Console.ReadLine());
            double valB = Convert.ToDouble(Console.ReadLine());
            double valC = Convert.ToDouble(Console.ReadLine());
            double valX1, valX2;

            double discriminant = Math.Pow(valB, 2) - (4 * valA * valC);

            if (discriminant == 0)
                Console.WriteLine("{0:F2}", -(valB / (2 * valA)));
            else if (discriminant > 0)
            {
                valX1 = -(valB / (2 * valA)) + (Math.Sqrt(discriminant)) / (2 * valA);
                valX2 = -(valB / (2 * valA)) - (Math.Sqrt(discriminant)) / (2 * valA);
                if (valX1 < valX2) Console.WriteLine("{0:F2}\n{1:F2}", valX1, valX2);
                else Console.WriteLine("{0:F2}\n{1:F2}", valX2, valX1);
            }
            else
                Console.WriteLine("no real roots");
        }
    }
}
