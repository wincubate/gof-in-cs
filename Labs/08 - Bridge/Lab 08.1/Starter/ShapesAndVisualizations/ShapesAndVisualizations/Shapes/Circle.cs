using System;
using System.Drawing;

namespace ShapesAndVisualizations
{
    abstract class Circle : Shape
    {
        public int Radius { get; }

        public Circle( Color color, int radius ) : base( color )
        {
            Radius = radius;
        }

        public override double Area => Math.PI * Math.Pow(Radius, 2);
    }

}
