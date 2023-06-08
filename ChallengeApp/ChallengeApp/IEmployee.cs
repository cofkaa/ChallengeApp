namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        char Gender { get; set; }
        Statistics GetStatistics();
    }
}
