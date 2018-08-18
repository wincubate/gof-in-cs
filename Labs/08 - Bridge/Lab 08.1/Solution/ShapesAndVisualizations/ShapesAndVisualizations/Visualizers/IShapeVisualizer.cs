using System.Drawing;
using System.Drawing.Drawing2D;

namespace ShapesAndVisualizations
{
    interface IShapeVisualizer
    {
        void VisualizeEllipse( Graphics graphics, int width, int height );
        void VisualizeRectangle( Graphics graphics, int width, int height );
    }
}
