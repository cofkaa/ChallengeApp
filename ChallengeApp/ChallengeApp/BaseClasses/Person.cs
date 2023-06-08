namespace ChallengeApp.BaseClases
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Gender { get; private set; }

        public Person(string name, string surname) : this(name, surname, 0) { }
        public Person(string name, string surname, char gender) : this(name, surname, 0, gender) { }
        public Person(string name, string surname, int age) : this(name, surname, age, '?') { }
        public Person(string name, string surname, int age, char gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
    }
}
