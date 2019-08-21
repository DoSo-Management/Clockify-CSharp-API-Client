using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clockify_API_Client_Core.Extensions
{
    public static class ExtensionMethods
    {
        public static string Times(this string text, int times) => Enumerable.Range(0, times).Select(t => text).Join();
        public static string Join(this IEnumerable<string> joinThese, string joinWith = "") => string.Join(joinWith, joinThese);
    }
}
