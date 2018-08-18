using System;

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

        public void Interpret( Context context ) => throw new NotImplementedException();
    }
}
