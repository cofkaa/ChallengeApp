using ChallengeApp.InheritingClasses;

namespace ChallengeApp.Tests

{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("Adam", "Nowak", 33);
            employee.AddGrade(3);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(3, statistics.Min);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Adam", "Nowak", 33);
            employee.AddGrade(3);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Max);
        }

        [Test]
        public void WhenEmployeeHasNoGrades_ShouldReturnZeroAverage()
        {
            // arrange
            var employee = new Employee("Adam", "Nowak", 33);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(0, statistics.Average);
        }

        [Test]
        public void WhenEmployeeCollectCharGrades_ShouldReturnAverage()
        {
            // arrange
            var employee = new Employee("Adam", "Nowak", 33);
            employee.AddGrade('A');
            employee.AddGrade('c');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(80, statistics.Average);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnAverageLetter()
        {
            // arrange
            var employee = new Employee("Adam", "Nowak", 33);
            employee.AddGrade(100);
            employee.AddGrade('c');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual('B', statistics.AverageLetter);
        }
    }
}