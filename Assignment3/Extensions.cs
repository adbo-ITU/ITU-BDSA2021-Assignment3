using System;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri uri) => uri.Scheme == "https";

        public static int WordCount(this string input) => Regex.Matches(input, @"\p{L}+").Count;
    }
}
