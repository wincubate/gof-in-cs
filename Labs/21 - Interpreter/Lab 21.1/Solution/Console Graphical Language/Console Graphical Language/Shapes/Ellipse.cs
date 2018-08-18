using System;

namespace ConsoleGraphicalLanguage
{
    class Ellipse : IShape
    {
        public void Interpret( Context context ) => context.Evaluation = "ellipse";
    }
}
