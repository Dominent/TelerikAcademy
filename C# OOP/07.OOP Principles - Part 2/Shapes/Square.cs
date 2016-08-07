namespace Shapes
{
    public class Square : Shape
    {
        public Square(int setWidth) : base(setWidth, setWidth) { }

        public override int CalculateSurface() => this.Width * this.Width;
    }
}
