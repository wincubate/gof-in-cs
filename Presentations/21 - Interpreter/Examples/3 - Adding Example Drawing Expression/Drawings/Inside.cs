using System;
using System.Drawing;

namespace Wincubate.InterpreterExamples
{
    class Inside : IDrawing
    {
        private readonly IDrawing _inner;
        private readonly IShape _outer;

        public Inside( IDrawing inner, IShape outer )
        {
            _inner = inner;
            _outer = outer;
        }

        public void Interpret( Context context )
        {
            int width = context.Rectangle.Width;
            int height = context.Rectangle.Height;

            _outer.Interpret(context);

            int widthMargin = width / 5;
            int heightMargin = height / 5;

            _inner.Interpret(
                new Context(
                    context.Graphics,
                    new Rectangle(
                        context.Rectangle.X + widthMargin,
                        context.Rectangle.Y + heightMargin,
                        width - 2 * widthMargin,
                        height - 2 * heightMargin
                    )
                )
            );
        }
    }
}
