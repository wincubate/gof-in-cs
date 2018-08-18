using System.Drawing;

namespace ShapesAndVisualizations
{
    abstract class Shape
    {
        public abstract double Area { get; }
        public abstract void Visualize( Graphics graphics );
        protected Color Color { get; set; }

        public Shape( Color color )
        {
            Color = color;
        }
    }
}
