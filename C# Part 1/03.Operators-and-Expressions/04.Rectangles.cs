using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0:F2} {1:F2}", (width * height), (2 * (width + height)));
        }
    }
}
