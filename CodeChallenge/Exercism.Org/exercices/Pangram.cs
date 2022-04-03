using System.Linq;

namespace Exercism.Org.exercices
{
    public static class Pangram
    {
        public static bool IsPangram(string input)
            => "abcdefghijklmnopqrstuvwxyz".All(input.ToLower().Contains);
    }
}