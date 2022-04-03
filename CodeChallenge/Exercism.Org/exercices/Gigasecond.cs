using System;

namespace Exercism.Org.exercices
{
    public static class Gigasecond
    {
        public static DateTime Add(DateTime birthday) =>
            birthday.AddSeconds(1E9);
    }
}
