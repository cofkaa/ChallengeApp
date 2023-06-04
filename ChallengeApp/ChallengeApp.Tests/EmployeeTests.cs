namespace ChallengeApp.Tests

{
    public class Tests
    {
        [Test]
        public void WhenEmployeeColectPoinst_ShouldReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam", "Nowak", 33);
            employee.AddPoints(3);
            employee.AddPoints(6);
            employee.SubtractPoints(9);

            // act
            var result = employee.Points;

            // assert
            Assert.AreEqual(0, result);
        }
    }
}