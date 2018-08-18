using System.Drawing;

namespace Wincubate.InterpreterExamples
{
    class Ellipse : IShape
    {
        public void Interpret( Context context )
        {
            context.Graphics.DrawEllipse(
                new Pen( Color.Black, 10 ),
                context.Rectangle
            );
        }
    }
}
