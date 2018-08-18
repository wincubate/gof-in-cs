using System.Drawing;

namespace Wincubate.InterpreterExamples
{
    class Context
    {
        public Graphics Graphics { get; }
        public Rectangle Rectangle { get; }

        public Context( Graphics graphics, Rectangle rectangle )
        {
            Graphics = graphics;
            Rectangle = rectangle;
        }
    }
}
