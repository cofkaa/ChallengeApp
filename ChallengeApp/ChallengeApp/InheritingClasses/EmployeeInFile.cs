using ChallengeApp.BaseClasses;
using ChallengeApp.DataModels;

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
            base.AddGrade(grade);
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }
        public override Statistics GetStatistics()
        {
            grades = new();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        try
                        {
                            var number = float.Parse(line);
                            grades.Add(number);
                        }
                        catch (Exception) { }
                        line = reader.ReadLine();
                    }
                }
            }
            return base.GetStatistics();
        }
    }
}
