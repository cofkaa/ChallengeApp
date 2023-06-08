using ChallengeApp.BaseClasses;
using System.Xml.Linq;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public EmployeeInFile() : base() { }
        public EmployeeInFile(string name, string surname) : base(name, surname) { }
        public EmployeeInFile(string name, string surname, char gender) : base(name, surname, gender) { }
        public EmployeeInFile(string name, string surname, int age) : base(name, surname, age) { }
        public EmployeeInFile(string name, string surname, int age, char gender) : base(name, surname, age, gender) { }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(decimal grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(long grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }
    }
}
