namespace Shapes
{
    public abstract class Shape
    {
        private readonly int width;
        private readonly int height;

        public Shape(int setWidth, int setHeight)
        {
            this.width = setWidth;
            this.height = setHeight;
        }

        public int Width { get { return this.width; } }
        public int Height { get { return this.height; } }

        public abstract int CalculateSurface();
    }
}
