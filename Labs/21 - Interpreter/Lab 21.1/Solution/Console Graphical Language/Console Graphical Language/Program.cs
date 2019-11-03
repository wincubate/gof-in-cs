using System;

namespace ConsoleGraphicalLanguage
{
    class Program
    {
        static void Main( string[] args )
        {
            IDrawing drawing = new NextTo(
                new Rotated(
                    new Box(),
                    45
                ),
                new Inside(
                    new Ellipse(),
                    new Box()
                )
            );

            Context context = new Context();
            drawing.Interpret(context);
            Console.WriteLine(context.Evaluation);
        }
    }
}


