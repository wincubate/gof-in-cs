using System;

namespace ConsoleGraphicalLanguage
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
            Context leftContext = new Context();
            _left.Interpret(leftContext);

            Context rightContext = new Context();
            _right.Interpret(rightContext);

            context.Evaluation = $"({leftContext.Evaluation} next to {rightContext.Evaluation})";
        }
    }
}
