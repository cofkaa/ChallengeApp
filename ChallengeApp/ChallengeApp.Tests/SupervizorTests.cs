namespace ChallengeApp.Tests
{
    public class SupervizorTests
    {
        [Test]
        public void WhenSupervizorCollectGrades_ShouldReturnCorrectMin()
        {
            // arrange
            var supervisor = new Supervisor();
            supervisor.AddGrade("+3");
            supervisor.AddGrade("-5");

            // act
            var statistics = supervisor.GetStatistics();

            // assert
            Assert.AreEqual(45, statistics.Min);
        }

        [Test]
        public void WhenSupervizorCollectGrades_ShouldReturnCorrectMax()
        {
            // arrange
            var supervisor = new Supervisor();
            supervisor.AddGrade("+3");
            supervisor.AddGrade("-5");

            // act
            var statistics = supervisor.GetStatistics();

            // assert
            Assert.AreEqual(75, statistics.Max);
        }

        [Test]
        public void WhenSupervizorCollectGrades_ShouldReturnNonNegativeMin()
        {
            // arrange
            var supervisor = new Supervisor();
            supervisor.AddGrade("-1");

            // act
            var statistics = supervisor.GetStatistics();

            // assert
            Assert.AreEqual(0, statistics.Max);
        }

        [Test]
        public void WhenSupervizorCollectGrades_ShouldReturnAverage()
        {
            // arrange
            var supervisor = new Supervisor();
            supervisor.AddGrade("3+");
            supervisor.AddGrade("-5");
            supervisor.AddGrade("1");

            // act
            var statistics = supervisor.GetStatistics();

            // assert
            Assert.AreEqual(40, statistics.Average);
        }
    }
}
