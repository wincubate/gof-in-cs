using System;

namespace Wincubate.InterpreterExamples
{
    // <drawing> ::= <drawing> next to <drawing>
    //             | <drawing> inside <shape>
    //             | <shape>
    // <shape> ::= <box> | <ellipse>

    class Context
    {
        // ...
    }

    interface IDrawing
    {
        void Interpret(Context context);
    }

    interface IShape
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
