using ChallengeApp.BaseClasses;

namespace ChallengeApp.InheritingClasses
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory() : base() { }
        public EmployeeInMemory(string name, string surname) : base(name, surname) { }
        public EmployeeInMemory(string name, string surname, char gender) : base(name, surname, gender) { }
        public EmployeeInMemory(string name, string surname, int age) : base(name, surname, age) { }
        public EmployeeInMemory(string name, string surname, int age, char gender) : base(name, surname, age, gender) { }

        public override void SayHello()
        {
            Console.WriteLine("HI!!!");
            base.SayHello();
        }
        protected override void AddGradeMainLogic(float grade)
        {
            grades.Add(grade);
        }
    }
}
