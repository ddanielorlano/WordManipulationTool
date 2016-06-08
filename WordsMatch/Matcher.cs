using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsMatch
{
    public static class Matcher
    {

        public static List<string> Match(string source,string other,out List<string> sourceTrimmed,out List<string> otherTrimmed)
        {
            sourceTrimmed = TrimChars(source);
            otherTrimmed = TrimChars(other);
            var difference = sourceTrimmed
               .Except(otherTrimmed, StringComparer.OrdinalIgnoreCase);
            var matches = sourceTrimmed
                .Where(x => !difference.Contains(x)).ToList();
            return matches;

        }
        public static List<string> Difference(string source, string other, out List<string> sourceTrimmed, out List<string> otherTrimmed)
        {
            sourceTrimmed = TrimChars(source);
            otherTrimmed = TrimChars(other);

            var difference = sourceTrimmed
                 .Except(otherTrimmed, StringComparer.OrdinalIgnoreCase)
                 .OrderBy(x => x).ToList();
            return difference;

        }
        private static readonly char[] _delimiters = new char[]
      { '"', '\'', ',', '.', '/', '?', '[', ']', '{', '}', '+', '=',':', ';', '<', '>', '(', ')', '*', '&', '^', '&', '!','@','#', '$', '%', '_', '-', '+', '=', '~', '`', '\\', '|', '\n',' ','\t','\r', };
        private static List<string>  TrimChars(string text)
        {
            return text
                .Split(_delimiters, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
        }
    }
}