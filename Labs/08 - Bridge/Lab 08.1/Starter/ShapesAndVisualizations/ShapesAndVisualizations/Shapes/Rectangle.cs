using System.Drawing;

namespace ShapesAndVisualizations
{
    abstract class Rectangle : Shape
    {
        public int Width { get; }
        public int Height { get; }

        public override double Area => Width * Height;

        public Rectangle( Color color, int width, int height ) : base( color )
        {
            Width = width;
            Height = height;
        }
    }
}
