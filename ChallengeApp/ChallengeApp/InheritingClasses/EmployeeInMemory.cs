using ChallengeApp.BaseClasses;

namespace ChallengeApp.InheritingClasses
{
    public class EmployeeInMemory : EmployeeBase
    {
        public delegate void WriteMessage(string message);
        public EmployeeInMemory() : base() { }
        public EmployeeInMemory(string name, string surname) : base(name, surname) { }
        public EmployeeInMemory(string name, string surname, char gender) : base(name, surname, gender) { }
        public EmployeeInMemory(string name, string surname, int age) : base(name, surname, age) { }
        public EmployeeInMemory(string name, string surname, int age, char gender) : base(name, surname, age, gender)
        {
            WriteMessage del;
            del = WriteMessageInConsole;
            del += WriteMessageInConsoleUpper;
            del("Mój tekst");
            del -= WriteMessageInConsole;
            del("Mój tekst2");
        }
        private void WriteMessageInConsole(string message)
        {
            Console.WriteLine(message);
        }
        private void WriteMessageInConsoleUpper(string message)
        {
            Console.WriteLine(message.ToUpper());
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
