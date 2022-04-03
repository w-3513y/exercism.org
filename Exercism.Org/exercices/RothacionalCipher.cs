using System.Linq;

namespace Exercism.Org.exercices
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            char Rotate(char c)
            {
                if (!char.IsLetter(c)) return c;
                int origin = char.IsLower(c) ? 'a' : 'A';
                return (char)(origin + ((c - origin + shiftKey) % 26));
            }
            return new string(text.Select(Rotate).ToArray());
        }
    }
}
