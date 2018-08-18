using System;

namespace ConsoleGraphicalLanguage
{
    class Box : IShape
    {
        public void Interpret( Context context ) => context.Evaluation = "box";
    }
}
