using System;

namespace Wincubate.TemplateMethodExamples
{
    class JsonPrettyPrinter : PrettyPrinterBase
    {
        private bool _firstProperty;

        public JsonPrettyPrinter() => _firstProperty = true;

        protected override void PrintBegin( string className ) => Console.Write("{");

        protected override void PrintEnd( string className ) => Console.WriteLine("}");

        protected override void PrintProperty( string propertyName, object propertyValue )
        {
            string commaOrNot = (_firstProperty ? "" : ",");
            Console.Write( $"{commaOrNot}\"{propertyName}\":\"{propertyValue}\"");

            _firstProperty = false;
        }
    }
}