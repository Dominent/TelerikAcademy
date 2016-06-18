using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double valA = Convert.ToDouble(Console.ReadLine());
            double valB = Convert.ToDouble(Console.ReadLine());
            double valH = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0:F7}",(valH * ((valA + valB)/2)));
        }
    }
}
