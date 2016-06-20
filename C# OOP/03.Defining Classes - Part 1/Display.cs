namespace Defining_Classes___Part_1
{
    class Display
    {
        public Display() : this(null) { }

        public Display(double? size): this(size, null) { }

        public Display(double? size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double? Size { get; set; }
        public int? NumberOfColors { get; set; }
    }
}
