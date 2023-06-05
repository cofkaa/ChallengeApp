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
            Console.WriteLine("grade string:" + grade);
            if (float.TryParse(grade, out float result))
                AddGrade(result);
            else
                Console.WriteLine("** string is not float");
        }
        public void AddGrade(decimal grade)
        {
            Console.WriteLine("grade decimal:" + grade);
            AddGrade((float)grade);
        }

        public void AddGrade(double grade)
        {
            Console.WriteLine("grade double:" + grade);
            AddGrade((float)grade);
        }

        public void AddGrade(long grade)
        {
            Console.WriteLine("grade long:" + grade);
            AddGrade((float)grade);
        }

        public void AddGrade(float grade)
        {
            Console.WriteLine("grade float:" + grade);
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
    }
}
