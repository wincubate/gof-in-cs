using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapesAndVisualizations
{
    class HatchedRectangle : Rectangle
    {
        public HatchedRectangle( Color color, int width, int height ) : base(color, width, height)
        {
        }

        public override void Visualize( Graphics graphics )
        {
            HatchBrush brush = new HatchBrush(
              HatchStyle.DiagonalCross,
              Color.Transparent,
              Color
            );
            graphics.FillRectangle(brush, 0, 0, Width, Height);
        }
    }
}
