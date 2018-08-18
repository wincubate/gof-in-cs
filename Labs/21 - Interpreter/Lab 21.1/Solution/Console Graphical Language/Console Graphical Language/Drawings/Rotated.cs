using System;

namespace ConsoleGraphicalLanguage
{
    class Rotated : IDrawing
    {
        private readonly IShape _inner;
        private readonly int _rotation;

        public Rotated( IShape inner, int rotation )
        {
            _inner = inner;
            _rotation = rotation;
        }

        public void Interpret( Context context )
        {
            Context sub = new Context();
            _inner.Interpret(sub);

            context.Evaluation = $"({sub.Evaluation} rotated {_rotation})";
        }
    }
}
