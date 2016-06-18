using System;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double valX = Convert.ToDouble(Console.ReadLine());
            double valY = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow((valX - 1), 2.0) + Math.Pow((valY - 1), 2.0));
            bool isInCircle = (distance <= 1.5);
            bool isInRectangle = ((valX >= -1) && (valX <= 5) && (valY <= 1) && (valY >= -1));

            Console.WriteLine((isInCircle ? "inside circle" : "outside circle") +
                " " + (isInRectangle ? "inside rectangle" : "outside rectangle"));
        }
    }
}
