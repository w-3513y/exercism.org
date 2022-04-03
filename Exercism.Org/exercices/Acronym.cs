using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercism.Org.exercices
{
    public static class Acronym
    {
        private static char AcronymLetter(string word)
            => char.ToUpper(word[0]); 
        private static IEnumerable<string> Words(string phrase)
            => Regex.Split(phrase, @"[^\w]+");
        public static string Abbreviate(string phrase)
            => new string(Words(phrase).Select(AcronymLetter).ToArray());
    }

}
