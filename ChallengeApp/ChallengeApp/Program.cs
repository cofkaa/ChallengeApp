using ChallengeApp;

List<Employee> employees = new List<Employee>();
employees.Add(new Employee("Adam", "Kowalski", 35));
employees.Add(new Employee("Kasia", "Nowak", 22));
employees.Add(new Employee("Jola", "Woźniak", 50));

int maxPoints = 0;
int newPoints;
Random random = new();
foreach (var employee in employees)
{
    for (int i = 0; i < 5; i++)
    {
        newPoints = random.Next(1, 11);
        Console.WriteLine(newPoints);
        employee.AddPoints(newPoints);
    }
    Console.WriteLine(employee.Name + " " + employee.Surname + " (" + employee.Age + ") " + employee.Points);
    if (maxPoints < employee.Points)
    {
        maxPoints = employee.Points;
    }
}

Console.WriteLine("********************");
Console.WriteLine("  The winner is:    ");
Console.WriteLine("********************");

foreach (var employee in employees)
{
    if (employee.Points == maxPoints)
    {
        Console.WriteLine(employee.Name + " " + employee.Surname + " (" + employee.Age + ") " + employee.Points);
    }
}

