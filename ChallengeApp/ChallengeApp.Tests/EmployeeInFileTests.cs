using ChallengeApp.InheritingClasses;

namespace ChallengeApp.Tests

{
    public class EmployeeInFileTests
    {
        [Test]
        public void WhenEmployeeInFileTestsCollectGrades_ShouldReturnCorrectMin()
        {
            // arrange
            EmployeeInFile.DeleteFileIfExists();
            var employee = new EmployeeInFile("Adam", "Nowak", 33);
            employee.AddGrade(3);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(3, statistics.Min);
        }

        [Test]
        public void WhenEmployeeInFileCollectGrades_ShouldReturnCorrectMax()
        {
            // arrange
            EmployeeInFile.DeleteFileIfExists();
            var employee = new EmployeeInFile("Adam", "Nowak", 33);
            employee.AddGrade(3);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Max);
        }

        [Test]
        public void WhenEmployeeInFileHasNoGrades_ShouldReturnZeroAverage()
        {
            // arrange
            EmployeeInFile.DeleteFileIfExists();
            var employee = new EmployeeInFile("Adam", "Nowak", 33);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(0, statistics.Average);
        }

        [Test]
        public void WhenEmployeeInFileCollectCharGrades_ShouldReturnAverage()
        {
            // arrange
            EmployeeInFile.DeleteFileIfExists();
            var employee = new EmployeeInFile("Adam", "Nowak", 33);
            employee.AddGrade('A');
            employee.AddGrade('c');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(80, statistics.Average);
        }

        [Test]
        public void WhenEmployeeInFileCollectGrades_ShouldReturnAverageLetter()
        {
            // arrange
            EmployeeInFile.DeleteFileIfExists();
            var employee = new EmployeeInFile("Adam", "Nowak", 33);
            employee.AddGrade(100);
            employee.AddGrade('c');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual('B', statistics.AverageLetter);
        }
    }
}