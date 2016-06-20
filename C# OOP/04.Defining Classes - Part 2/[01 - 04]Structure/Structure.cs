namespace Structure
{
    using System;

    class Structure
    {
        static void Main()
        {
            var points = new[]
            {
                new Point3D()
                {
                    X = 32.5,
                    Y = 63.2,
                    Z = 10.2
                },
                 new Point3D()
                {
                    X = 22.5,
                    Y = 13.2,
                    Z = 19.2
                },

            };

            Console.WriteLine(points[0]);
            Console.WriteLine(Point3D.Origin);
            Console.WriteLine($"{CalcDist3DPoints.Calculate(points[0], points[1]):F2}");

            var rnd = new Random();
            var path = new Path();
            for (var i = 0; i < 20; i++) // Generate 20 Random Points
            {
                path.AddPoint(new Point3D()
                {
                    X = (rnd.NextDouble() * 15),
                    Y = (rnd.NextDouble() * 15),
                    Z = (rnd.NextDouble() * 15)
                });
            }
            PathStorage.SavePaths(path);

            path = PathStorage.LoadPaths();

            Console.WriteLine(path);
        }
    }
}
