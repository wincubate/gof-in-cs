using System.Drawing;

namespace ShapesAndVisualizations
{
    abstract class ShapeVisualizerBase : IShapeVisualizer
    {
        public virtual void VisualizeEllipse( Graphics graphics, int width, int height )
        {
            graphics.FillEllipse(Brush, 0, 0, width, height);
        }
        public void VisualizeRectangle( Graphics graphics, int width, int height )
        {
            graphics.FillRectangle(Brush, 0, 0, width, height);
        }

        public Brush Brush { get; }

        public ShapeVisualizerBase( Brush brush )
        {
            Brush = brush;
        }
    }
}
