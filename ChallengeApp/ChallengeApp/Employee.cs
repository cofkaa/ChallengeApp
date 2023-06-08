using ChallengeApp.DataModels;
using ChallengeApp.Interfaces;

namespace ChallengeApp
{
    public class Employee : IEmployee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Gender { get; private set; }

        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Employee(string name, string surname, int age) : this(name, surname)
        {
            this.Age = age;
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                AddGrade(result);
            else
                throw new Exception("String is not float");
        }

        public void AddGrade(char grade)
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
        public void AddGrade(decimal grade)
        {
            AddGrade((float)grade);
        }

        public void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }

        public void AddGrade(long grade)
        {
            AddGrade((float)grade);
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
                this.grades.Add(grade);
            else
                throw new Exception("Invalid grade value");
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.CalcStatisticsForGradesList(grades);
            return statistics;
        }
    }
}
