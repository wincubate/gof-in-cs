using System.Collections.Generic;
using System.Dynamic;

namespace Wincubate.TemplateMethodExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            dynamic person = new ExpandoObject();
            person.FirstName = "Terry";
            person.LastName = "Tate";
            person.Occupation = "Office Linebacker";

            XmlPrettyPrinter pp = new XmlPrettyPrinter();

            pp.PrintPreamble();

            pp.PrintBegin(nameof(person));

            foreach (KeyValuePair<string, object> kvp in person as IDictionary<string, object>)
            {
                pp.PrintProperty(kvp.Key, kvp.Value);
            }

            pp.PrintEnd(nameof(person));
        }
    }
}
