using System.Drawing;

namespace ShapesAndVisualizations
{
    abstract class Shape
    {
        public abstract double Area { get; }
        public abstract void Visualize( Graphics graphics );

        protected readonly IShapeVisualizer _visualizer;

        public Shape( IShapeVisualizer visualizer )
        {
            _visualizer = visualizer;
        }
    }
}
