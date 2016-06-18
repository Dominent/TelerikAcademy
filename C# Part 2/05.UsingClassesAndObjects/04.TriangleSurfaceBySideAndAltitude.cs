using System;

namespace TriangleSurfaceBySideAndAltitude
{
    class TriangleSurfaceBySideAndAltitude
    {
        static void Main()
        {
            decimal side = Convert.ToDecimal(Console.ReadLine());
            decimal altitude = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("{0:F2}",(0.5m * side * altitude));
        }
    }
}
