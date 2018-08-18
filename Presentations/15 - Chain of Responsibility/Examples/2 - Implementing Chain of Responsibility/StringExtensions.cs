using System.Linq;

namespace Wincubate.ChainOfResponsibilityExamples
{
    public static class StringExtensions
    {
        public static bool ContainsAnyOf( this string that, params string[] words ) => that
                .ToLower()
                .Split(' ', ',', '!', '\n', '\r')
                .Intersect(words.Select(w => w.ToLower()))
                .Any();
    }
}
