using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsMatch
{
    public static class Formatter
    {
        private static char[] splitChars = { '\n', ' ' };
        public static List<string> AddToWord(string words, string before, string after)
        {
            return string.IsNullOrWhiteSpace(words) ? null :
             words.Split(splitChars, StringSplitOptions.RemoveEmptyEntries)
             .Select(x => $"{before}{x}{after}").ToList();
        }
        public static List<string> RemoveFromWords(string words, char[] dels)
        {
            return string.IsNullOrWhiteSpace(words) ? null :
             words.Split(dels, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x).ToList();
        }
    }
}
