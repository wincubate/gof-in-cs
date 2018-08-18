using System.Drawing;

namespace ShapesAndVisualizations
{
    class SolidColorVisualizer : ShapeVisualizerBase
    {
        public SolidColorVisualizer( Color color ) : base(new SolidBrush(color))
        {
        }
    }
}
