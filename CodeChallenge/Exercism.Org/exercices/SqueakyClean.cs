namespace Exercism.Org.exercices
{
    public static class Identifier
    {
        private static bool IsGreekLowercase(char c) => (c >= 'α' && c <= 'ω');
        public static string Clean(string identifier)
        {
            var stringBuilder = new System.Text.StringBuilder();
            var isAfterDash = false;
            foreach (var c in identifier)
            {
                stringBuilder.Append(c switch
                {
                    _ when IsGreekLowercase(c) => default,
                    _ when isAfterDash => char.ToUpperInvariant(c),
                    _ when char.IsWhiteSpace(c) => '_',
                    _ when char.IsControl(c) => "CTRL",
                    _ when char.IsLetter(c) => c,
                    _ => default, //default = null
                });
                isAfterDash = c.Equals('-');
            }
            return stringBuilder.ToString();
        }
    }
}
/*
Assert.Equal("A", Identifier.Clean("A"));
Assert.Equal("àḃç", Identifier.Clean("àḃç"));
Assert.Equal("my___Id", Identifier.Clean("my   Id"));
Assert.Equal("myCTRLId", Identifier.Clean("my\0Id"));
Assert.Equal(string.Empty, Identifier.Clean("😀😀😀"));
Assert.Equal(string.Empty, Identifier.Clean(string.Empty));
Assert.Equal("àḂç", Identifier.Clean("à-ḃç"));
Assert.Equal("MyΟFinder", Identifier.Clean("MyΟβιεγτFinder"));
Assert.Equal("_AbcĐCTRL", Identifier.Clean("9 -abcĐ😀ω\0"));
*/
