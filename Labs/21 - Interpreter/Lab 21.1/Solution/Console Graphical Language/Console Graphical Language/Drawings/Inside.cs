using System;

namespace ConsoleGraphicalLanguage
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
            Context innerContext = new Context();
            _inner.Interpret(innerContext);

            Context outerContext = new Context();
            _outer.Interpret(outerContext);

            context.Evaluation = $"({innerContext.Evaluation} inside {outerContext.Evaluation})";
        }
    }
}
