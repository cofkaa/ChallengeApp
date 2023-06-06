using ChallengeApp;

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
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine("****************************");
    statistics = employee.GetStatisticsWithForEach();
    Console.WriteLine("--GetStatisticsWithForEach()   ");
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine("****************************");
    statistics = employee.GetStatisticsWithFor();
    Console.WriteLine("--GetStatisticsWithFor()   ");
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine("****************************");
    statistics = employee.GetStatisticsWithDoWhile();
    Console.WriteLine("--GetStatisticsWithDoWhile()   ");
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine("****************************");
    statistics = employee.GetStatisticsWithWhile();
    Console.WriteLine("--GetStatisticsWithWhile()   ");
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine("****************************");
    break;
}
