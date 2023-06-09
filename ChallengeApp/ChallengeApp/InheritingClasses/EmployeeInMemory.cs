using ChallengeApp.BaseClasses;

namespace ChallengeApp.InheritingClasses
{
    public class EmployeeInMemory : EmployeeBase
    {
        public delegate string WriteMessage(string message);
        public EmployeeInMemory() : base() { }
        public EmployeeInMemory(string name, string surname) : base(name, surname) { }
        public EmployeeInMemory(string name, string surname, char gender) : base(name, surname, gender) { }
        public EmployeeInMemory(string name, string surname, int age) : base(name, surname, age) { }
        public EmployeeInMemory(string name, string surname, int age, char gender) : base(name, surname, age, gender)
        {
            WriteMessage del;
            del = ReturnMessage;
            del("Mój tekst");
            ReturnMessage("Mój tekst");
        }
        private string ReturnMessage(string message)
        {
            return message;
        }
        public override void SayHello()
        {
            Console.WriteLine("HI!!!");
            base.SayHello();
        }
        public override void AddGrade(float grade)
        {
            base.AddGrade(grade);
            grades.Add(grade);
        }
    }
}
