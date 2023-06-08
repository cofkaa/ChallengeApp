using ChallengeApp.BaseClasses;

namespace ChallengeApp.InheritingClasses
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile() : base() { }
        public EmployeeInFile(string name, string surname) : base(name, surname) { }
        public EmployeeInFile(string name, string surname, char gender) : base(name, surname, gender) { }
        public EmployeeInFile(string name, string surname, int age) : base(name, surname, age) { }
        public EmployeeInFile(string name, string surname, int age, char gender) : base(name, surname, age, gender) { }

        public override void AddGrade(float grade)
        {
            if (grade < 0 || grade > 100)
                throw new Exception("Invalid grade value");
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }
    }
}
