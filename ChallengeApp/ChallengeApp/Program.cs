using ChallengeApp.InheritingClasses;

Console.WriteLine("Witamy w Programie ABC do oceny pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Aga", "Nowak", 33, 'K');
employee.SayHello();

var input = "";
var input2 = "";
do
{
    Console.WriteLine("podaj ocenę pracownika:");
    input = Console.ReadLine();
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"**błąd: {e.Message}");
    }

    Console.WriteLine($"wprowadzono ocenę: {input}. czy chcesz podać kolejną ocenę (t/n)?");
    input2 = Console.ReadLine();
} while (input2 == "t" || input2 == "t");

var statistics = employee.GetStatistics();
Console.WriteLine("****************************");
Console.WriteLine($"{employee.Name} {employee.Surname} ({employee.Age})");
Console.WriteLine($"average: {statistics.Average:n2}");
Console.WriteLine($"averageletter: {statistics.AverageLetter}");
Console.WriteLine($"min: {statistics.Min}");
Console.WriteLine($"max: {statistics.Max}");
Console.WriteLine("****************************");
