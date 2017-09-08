using System.Collections.Generic;
using System.Linq;

namespace PBandJ.Api.Helpers.cs
{
    public static class EnumerableExtensions
    {
        public static string[] EnumerateToStringArray(this IEnumerable<string> source)
        {
            var resultArray = source as string[] ?? source.ToArray();
            return resultArray;
        }
    }
}
