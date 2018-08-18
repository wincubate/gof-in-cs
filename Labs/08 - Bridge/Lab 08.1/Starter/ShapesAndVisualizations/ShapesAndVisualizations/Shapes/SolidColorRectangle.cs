using System.Drawing;

namespace ShapesAndVisualizations
{
    class SolidColorRectangle : Rectangle
    {
        public SolidColorRectangle( Color color, int width, int height ) : base( color, width, height )
        {
        }

        public override void Visualize( Graphics graphics )
        {
            Brush brush = new SolidBrush(Color);
            graphics.FillRectangle(brush, 0, 0, Width, Height);
        }
    }
}
