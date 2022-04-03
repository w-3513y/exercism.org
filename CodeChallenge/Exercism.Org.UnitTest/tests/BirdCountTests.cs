using Exercism.Org.exercices;
using Xunit;

namespace Exercism.Org.UnitTest.tests
{
    public class BirdCountTests
    {
        [Fact]
        public void LastWeek()
        {
            Assert.Equal(new int[] { 0, 2, 5, 3, 7, 8, 4 }, BirdCount.LastWeek());
        }

        [Fact]
        public void Today()
        {
            var counts = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            var birdCount = new BirdCount(counts);
            Assert.Equal(0, birdCount.Today());
        }
    }
}