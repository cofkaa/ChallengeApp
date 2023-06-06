using ChallengeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee("Adam", "Kowalski", 35));
        employees.Add(new Employee("Kasia", "Nowak", 22));
        employees.Add(new Employee("Jola", "Woźniak", 50));

        int newGrade;
        Random random = new();
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name} {employee.Surname} ({employee.Age})");
            for (int i = 0; i < random.Next(0, 10); i++)
            {
                newGrade = random.Next(0, 101);
                Console.WriteLine(newGrade);
                employee.AddGrade(newGrade);
            }

            var statistics = employee.GetStatistics();
            Console.WriteLine("****************************");
            Console.WriteLine("--GetStatistics()   ");
            Console.WriteLine($"Average: {statistics.Average:N2}");
            Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
            Console.WriteLine($"Min: {statistics.Min}");
            Console.WriteLine($"Max: {statistics.Max}");
            Console.WriteLine("****************************");
            break;
        }
    }
}