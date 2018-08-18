using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndVisualizations
{
    class GradientVisualizer : ShapeVisualizerBase
    {
        public GradientVisualizer( Color color ) : base(
            new LinearGradientBrush(
                new PointF( 0, 0 ),
                new PointF( 0, 300 ),
                color,
                Color.Transparent
            ))
        {
        }
    }
}
