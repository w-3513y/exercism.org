using System.Linq;

namespace Exercism.Org.exercices
{
    public static class Bob
    {
        public static string Response(string input)
        {
            input = input.Trim();

            if (input.Length == 0) return "Fine. Be that way!";
            if (input.Any(char.IsUpper) && !input.Any(char.IsLower)) return "Whoa, chill out!";
            if (input.EndsWith("?")) return "Sure.";
            return "Whatever.";
        }
    }
}