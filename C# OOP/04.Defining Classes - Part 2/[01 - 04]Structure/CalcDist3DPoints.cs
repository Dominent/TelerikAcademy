namespace Structure
{
    using System;

    public static class CalcDist3DPoints
    {
        public static double Calculate(Point3D point1, Point3D point2) => Math.Sqrt(Math.Pow((point1.X - point2.X), 2)
                             + Math.Pow((point1.Y - point2.Y), 2)
                             + Math.Pow((point1.Z - point2.Z), 2));
    }
}
