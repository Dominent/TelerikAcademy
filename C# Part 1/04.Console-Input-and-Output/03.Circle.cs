using System;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            double input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0:F2} {1:F2}",
                (2 * Math.PI * input),
                (Math.PI * Math.Pow(input, 2))
                );
        }
    }
}
