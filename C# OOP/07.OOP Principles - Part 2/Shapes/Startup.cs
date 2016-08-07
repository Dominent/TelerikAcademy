namespace Shapes
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var collection = new Shape[]
            {
                new Rectangle(10, 15),
                new Triangle(3, 2),
                new Square(5)
            };

            foreach (var item in collection)
                Console.WriteLine(item.CalculateSurface());
        }
    }
}
