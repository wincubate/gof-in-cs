using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapesAndVisualizations
{
    class HatchedVisualizer : ShapeVisualizerBase
    {
        public HatchedVisualizer( Color color ) : base(
            new HatchBrush(
              HatchStyle.DiagonalCross,
              Color.Transparent,
              color
            ))
        {
        }
    }
}
