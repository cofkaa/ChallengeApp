namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Points { get; private set; }

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void AddPoints(int points)
        {
            this.Points += points;
        }

        public void SubtractPoints(int points)
        {
            this.Points -= points;
        }
    }
}
