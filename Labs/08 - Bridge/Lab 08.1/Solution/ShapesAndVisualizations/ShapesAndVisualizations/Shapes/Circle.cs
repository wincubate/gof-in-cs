using System;
using System.Drawing;

namespace ShapesAndVisualizations
{
    class Circle : Shape
    {
        public int Radius { get; }

        public override double Area => Math.PI * Math.Pow(Radius, 2);

        public override void Visualize( Graphics graphics )
        {
            _visualizer.VisualizeEllipse( graphics, Radius, Radius );
        }

        public Circle( IShapeVisualizer visualizer, int radius ) : base(visualizer)
        {
            Radius = radius;
        }
    }
}
