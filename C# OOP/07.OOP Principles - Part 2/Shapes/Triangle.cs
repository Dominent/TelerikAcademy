namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int setWidth, int setHeight) : base(setWidth, setHeight) { }

        public override int CalculateSurface() => this.Height * this.Width;
    }
}
