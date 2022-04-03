using System.Linq;

namespace Exercism.Org.exercices
{
    public class BirdCount
    {
        private int[] birdsPerDay;
        public BirdCount(int[] birdsPerDay)
            => this.birdsPerDay = birdsPerDay;
        public static int[] LastWeek()
            => new[] { 0, 2, 5, 3, 7, 8, 4 };
        public int Today()
            => birdsPerDay[^1];
        public int IncrementTodaysCount()
            => birdsPerDay[^1]++;
        public bool HasDayWithoutBirds()
            => birdsPerDay.Any(x => x == 0);
        public int CountForFirstDays(int numberOfDays)
            => birdsPerDay.Take(numberOfDays).Sum();
        public int BusyDays()
            => birdsPerDay.Where(x => x >= 5).Count();
    }
}