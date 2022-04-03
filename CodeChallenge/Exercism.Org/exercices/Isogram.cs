using System.Linq;

namespace Exercism.Org.exercices
{
    public static class Isogram
    {
        public static bool IsIsogram(string word)
            => word.Where(char.IsLetter)
                   .GroupBy(char.ToLower)
                   .All(g => g.Count() == 1);
    }
}