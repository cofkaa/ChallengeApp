namespace ChallengeApp
{
    public class Employee : Person
    {
        public string Surname { get; private set; }
        public int Age { get; private set; }

        private List<float> grades = new List<float>();

        public Employee() : this("no name") { }
        public Employee(string name) : this(name, "no surname") { }
        public Employee(string name, string surname) : this(name, surname, 0) { }
        public Employee(string name, string surname, int age) : base(name)
        {
            this.Surname = surname;
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

            statistics.Average = 0;

            if (this.grades.Count > 0)
            {
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                foreach (var grade in this.grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
                statistics.Average /= this.grades.Count;
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
