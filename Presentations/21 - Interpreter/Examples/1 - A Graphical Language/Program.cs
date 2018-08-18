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

    interface IExpression
    {
        void Interpret( Context context );
    }

    interface IDrawing : IExpression
    {
    }

    interface IShape : IExpression
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
