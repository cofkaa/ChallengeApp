using ChallengeApp.DataModels;
using ChallengeApp.Interfaces;

namespace ChallengeApp.BaseClasses
{
    public abstract class EmployeeBase : IEmployee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Gender { get; private set; }

        protected List<float> grades = new();

        public EmployeeBase() : this("no-name", "no-surname", 0, '?') { }
        public EmployeeBase(string name, string surname) : this(name, surname, 0, '?') { }
        public EmployeeBase(string name, string surname, char gender) : this(name, surname, 0, gender) { }
        public EmployeeBase(string name, string surname, int age) : this(name, surname, age, '?') { }
        public EmployeeBase(string name, string surname, int age, char gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Gender = gender;
        }
        public virtual void SayHello()
        {
            Console.WriteLine($"Hello! I'm {Name} {Surname}");
        }
        public void AddGrade(char grade)
        {
            var pointsForGrade = grade switch
            {
                'A' or 'a' => 100,
                'B' or 'b' => 80,
                'C' or 'c' => 60,
                'D' or 'd' => 40,
                'E' or 'e' => 20,
                _ => throw new Exception("Wrong letter"),
            };
            AddGrade(pointsForGrade);
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                AddGrade(result);
            else
                throw new Exception("String is not float");
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
        public virtual void AddGrade(float grade)
        {
            if (grade < 0 || grade > 100)
                throw new Exception("Invalid grade value");
        }
        public virtual Statistics GetStatistics()
        {
            var statistics = new Statistics();

            if (grades.Count > 0)
            {
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                foreach (var grade in grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
                statistics.Average /= grades.Count;
            }
            switch (statistics.Average)
            {
                case > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case > 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
