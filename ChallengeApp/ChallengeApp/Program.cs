using ChallengeApp.InheritingClasses;

Console.WriteLine("Witamy w Programie ABC do oceny pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new EmployeeInFile("Aga", "Nowak", 33, 'K');
employee.SayHello();
employee.GradeAdded += EmployeeGradeAdded;

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

    Console.WriteLine("Czy chcesz podać kolejną ocenę (t/n)?");
    input2 = Console.ReadLine();
    if (input2 == null)
        break;
} while (input2.ToLower() == "t");

employee.GradeAdded -= EmployeeGradeAdded;

var statistics = employee.GetStatistics();
Console.WriteLine("****************************");
Console.WriteLine($"{employee.Name} {employee.Surname} ({employee.Age})");
Console.WriteLine($"average: {statistics.Average:n2}");
Console.WriteLine($"averageletter: {statistics.AverageLetter}");
Console.WriteLine($"min: {statistics.Min}");
Console.WriteLine($"max: {statistics.Max}");
Console.WriteLine("****************************");

void EmployeeGradeAdded(object sender, EventArgs args, float grade)
{
    Console.WriteLine($"Dodano nową ocenę {grade}.");
}