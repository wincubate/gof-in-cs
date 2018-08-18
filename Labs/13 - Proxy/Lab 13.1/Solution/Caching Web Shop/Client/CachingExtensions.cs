using System.Collections.Generic;

namespace Client
{
    internal static class CachingExtensions
    {
        internal static string AllCacheKey => "Products/all";
        internal static string ToCacheKey( this int id ) => $"Products/{id}";
    }
}
