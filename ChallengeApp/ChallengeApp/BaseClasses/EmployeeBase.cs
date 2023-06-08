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
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);

        public abstract void AddGrade(decimal grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(long grade);
        public abstract void AddGrade(float grade);
        public Statistics GetStatistics()
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
