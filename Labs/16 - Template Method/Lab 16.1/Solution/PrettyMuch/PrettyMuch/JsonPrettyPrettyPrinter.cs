using Library;
using System;

namespace PrettyMuch
{
    class JsonPrettyPrettyPrinter : PrettyPrinterBase
    {
        private bool _firstProperty;

        public JsonPrettyPrettyPrinter() => _firstProperty = true;

        protected override void PrintBegin( string className ) => Console.Write("{ ");

        protected override void PrintEnd( string className ) => Console.WriteLine(" }");

        protected override void PrintProperty( string propertyName, object propertyValue )
        {
            string separator = (_firstProperty ? "" : $",{Environment.NewLine}  ");
            Console.Write($"{separator}\"{propertyName}\": \"{propertyValue}\"");

            _firstProperty = false;
        }
    }
}
