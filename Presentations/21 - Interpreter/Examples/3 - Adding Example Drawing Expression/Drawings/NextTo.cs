using System;
using System.Drawing;

namespace Wincubate.InterpreterExamples
{
    class NextTo : IDrawing
    {
        private readonly IDrawing _left;
        private readonly IDrawing _right;

        public NextTo( IDrawing left, IDrawing right )
        {
            _left = left;
            _right = right;
        }

        public void Interpret( Context context )
        {
            int width = context.Rectangle.Width;
            int height = context.Rectangle.Height;
            int margin = 50;

            int childWidth = width / 2 - margin;
            int childHeight = height - margin;

            _left.Interpret(
                new Context(
                    context.Graphics,
                    new Rectangle(
                        context.Rectangle.X + margin / 2,
                        context.Rectangle.Y + margin / 2,
                        childWidth,
                        childHeight
                    )
                )
            );

            _right.Interpret(
                new Context(
                    context.Graphics,
                    new Rectangle(
                        context.Rectangle.X + (width + margin) / 2,
                        context.Rectangle.Y + margin / 2,
                        childWidth,
                        childHeight
                    )
                )
            );
        }
    }
}
