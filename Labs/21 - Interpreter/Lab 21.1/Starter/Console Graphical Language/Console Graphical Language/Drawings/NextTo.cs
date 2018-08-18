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

        public void Interpret( Context context ) => throw new NotImplementedException();
    }
}
