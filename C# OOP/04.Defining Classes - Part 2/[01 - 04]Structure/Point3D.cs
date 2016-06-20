namespace Structure
{
    public struct Point3D
    {
        public static Point3D Origin { get; } = new Point3D()
        {
            X = 0,
            Y = 0,
            Z = 0
        };

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public override string ToString() => $"[ X: {X}, Y: {Y}, Z: {Z} ]";
    }
}
