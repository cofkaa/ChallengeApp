using ChallengeApp.DataModels;
using ChallengeApp.Interfaces;

namespace ChallengeApp
{
    public class Supervisor : EmployeeInMemory
    {
        public Supervisor() : base() { }
        public Supervisor(string name, string surname) : base(name, surname) { }
        public Supervisor(string name, string surname, char gender) : base(name, surname, gender) { }
        public Supervisor(string name, string surname, int age) : base(name, surname, age) { }
        public Supervisor(string name, string surname, int age, char gender) : base(name, surname, age, gender) { }
        public new void AddGrade(string grade)
        {
            bool isPlus = grade.Contains('+');
            bool isMinus = grade.Contains('-');
            if (isPlus && isMinus)
            {
                throw new Exception("Błędna ocena. Ocena nie może zawierać \"+\" i \"-\" jednocześnie");
            }
            var trimgedGade = grade.Trim(new char[] { '+', '-', ' ' });
            int pointsForGrade;
            switch (trimgedGade)
            {
                case "6":
                    pointsForGrade = 100;
                    break;
                case "5":
                    pointsForGrade = 80;
                    break;
                case "4":
                    pointsForGrade = 60;
                    break;
                case "3":
                    pointsForGrade = 40;
                    break;
                case "2":
                    pointsForGrade = 20;
                    break;
                case "1":
                    pointsForGrade = 0;
                    break;
                default:
                    throw new Exception("Błędna ocena. Ocena musi zawierać się w przedziale od 1 do 6");
            }
            if (isPlus)
                pointsForGrade += 5;
            else if (isMinus)
                pointsForGrade -= 5;
            grades.Add(Math.Max(0, pointsForGrade));
        }
    }
}
