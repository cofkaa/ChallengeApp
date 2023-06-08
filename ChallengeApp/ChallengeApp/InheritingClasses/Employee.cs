namespace ChallengeApp.InheritingClasses
{
    public class Employee : EmployeeInMemory
    {
        public Employee() : base() { }
        public Employee(string name, string surname) : base(name, surname) { }
        public Employee(string name, string surname, int age) : base(name, surname, age) { }
        public Employee(string name, string surname, char gender) : base(name, surname, gender) { }
        public Employee(string name, string surname, int age, char gender) : base(name, surname, age, gender) { }
    }
}
