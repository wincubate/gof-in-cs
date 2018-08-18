using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapesAndVisualizations
{
    class HatchedCircle : Circle
    {
        public HatchedCircle( Color color, int radius ) : base(color, radius)
        {
        }

        public override void Visualize( Graphics graphics )
        {
            HatchBrush brush = new HatchBrush(
              HatchStyle.DiagonalCross,
              Color.Transparent,
              Color
            );
            graphics.FillEllipse(brush, 0, 0, Radius, Radius);
        }
    }
}
