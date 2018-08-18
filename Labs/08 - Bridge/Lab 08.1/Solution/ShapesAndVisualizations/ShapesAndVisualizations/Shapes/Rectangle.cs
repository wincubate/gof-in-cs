using System.Drawing;

namespace ShapesAndVisualizations
{
    class Rectangle : Shape
    {
        public int Width { get; }
        public int Height { get; }

        public override double Area => Width * Height;

        public override void Visualize( Graphics graphics )
        {
            _visualizer.VisualizeRectangle(graphics, Width, Height);
        }

        public Rectangle( IShapeVisualizer visualizer, int width, int height ) : base( visualizer )
        {
            Width = width;
            Height = height;
        }
    }
}
