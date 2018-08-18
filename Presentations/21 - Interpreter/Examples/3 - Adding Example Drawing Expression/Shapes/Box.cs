using System.Drawing;

namespace Wincubate.InterpreterExamples
{
    class Box : IShape
    {
        public void Interpret( Context context )
        {
            context.Graphics.DrawRectangle(
                new Pen(Color.Black, 10),
                context.Rectangle
            );
        }
    }
}
