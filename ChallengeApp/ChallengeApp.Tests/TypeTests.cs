using ChallengeApp.InheritingClasses;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void IntShouldReturnSameValue()
        {
            // arrange
            int number1 = 5;
            int number2 = 5;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void FloatShouldReturnSameValue()
        {
            // arrange
            float number1 = 10.5f;
            float number2 = 105E-1f;

            // act
            
            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void StringShouldReturnDifferentValue()
        {
            // arrange
            string text1 = "miasto";
            string text2 = "Miasto";

            // act
            
            // assert
            Assert.AreNotEqual(text1, text2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            // arrange
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");
             
            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name, "", 0);
        }
    }
}
