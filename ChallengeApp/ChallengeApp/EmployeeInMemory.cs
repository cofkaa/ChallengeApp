using ChallengeApp.BaseClasses;

namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory() : base() { }
        public EmployeeInMemory(string name, string surname) : base(name, surname) { }
        public EmployeeInMemory(string name, string surname, char gender) : base(name, surname, gender) { }
        public EmployeeInMemory(string name, string surname, int age) : base(name, surname, age) { }
        public EmployeeInMemory(string name, string surname, int age, char gender) : base(name, surname, age, gender) { }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                AddGrade(result);
            else
                throw new Exception("String is not float");
        }

        public override void AddGrade(decimal grade)
        {
            AddGrade((float)grade);
        }

        public override void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }

        public override void AddGrade(long grade)
        {
            AddGrade((float)grade);
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
                this.grades.Add(grade);
            else
                throw new Exception("Invalid grade value");
        }
    }
}
