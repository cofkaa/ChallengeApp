using System.Runtime.InteropServices;

namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        private List<float> grades = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                AddGrade(result);
            else
                Console.WriteLine("** string is not float");
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
                Console.WriteLine("** invalid grade value");
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

            return statistics;
        }

        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();

            statistics.Average = 0;

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            if (this.grades.Count > 0)
                statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();

            statistics.Average = 0;

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Average += grades[i];
            }
            if (this.grades.Count > 0)
                statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            if (this.grades.Count > 0)
            {
                var i = 0;
                do
                {
                    statistics.Min = Math.Min(statistics.Min, grades[i]);
                    statistics.Max = Math.Max(statistics.Max, grades[i]);
                    statistics.Average += grades[i];
                    i++;
                } while (i < this.grades.Count);

                statistics.Average /= this.grades.Count;
            }
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var i = 0;
            while (i < this.grades.Count)
            {
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Average += grades[i];
                i++;
            }
            if (this.grades.Count > 0)
                statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}
