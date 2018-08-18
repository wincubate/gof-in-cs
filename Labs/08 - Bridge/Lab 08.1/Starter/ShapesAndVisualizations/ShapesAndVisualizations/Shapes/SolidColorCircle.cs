using System.Drawing;

namespace ShapesAndVisualizations
{
    class SolidColorCircle : Circle
    {
        public SolidColorCircle( Color color, int radius ) : base(color, radius)
        {
        }

        public override void Visualize( Graphics graphics )
        {
            Brush brush = new SolidBrush(Color);
            graphics.FillEllipse(brush, 0, 0, Radius, Radius);
        }
    }
}
