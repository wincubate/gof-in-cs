namespace ShapesAndVisualizations
{
    class Square : Rectangle
    {
        public Square( IShapeVisualizer visualizer, int side )
            : base(visualizer, side, side)
        {
        }
    }
}
