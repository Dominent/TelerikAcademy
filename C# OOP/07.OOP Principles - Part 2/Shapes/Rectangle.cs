namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int setWidth, int setHeight) : base(setWidth, setHeight) { }

        public override int CalculateSurface() => (this.Height * this.Width) / 2;
    }
}
