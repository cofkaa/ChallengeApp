using ChallengeApp.InheritingClasses;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Witamy w Programie ABC do oceny pracowników");
        Console.WriteLine("============================================");
        Console.WriteLine();

        var employee = new EmployeeInFile("Aga", "Nowak");
        employee.SayHello();
        employee.AddGrade(10.5f);
        employee.AddGrade(0.6510m);
        employee.AddGrade(56.7d);
        employee.AddGrade(10);
        employee.AddGrade('A');
        employee.AddGrade("20,48");
        //var input = "";
        //var input2 = "";
        //do
        //{
        //    Console.WriteLine("Podaj ocenę pracownika:");
        //    input = Console.ReadLine();
        //    try
        //    {
        //        employee.AddGrade(input);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"**Błąd: {e.Message}");
        //    }

        //    Console.WriteLine($"Wprowadzono ocenę: {input}. Czy chcesz podać kolejną ocenę (T/N)?");
        //    input2 = Console.ReadLine();
        //} while (input2 == "T" || input2 == "t");

        //var statistics = employee.GetStatistics();
        //Console.WriteLine("****************************");
        //Console.WriteLine($"{employee.Name} {employee.Surname} ({employee.Age})");
        //Console.WriteLine($"Average: {statistics.Average:N2}");
        //Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
        //Console.WriteLine($"Min: {statistics.Min}");
        //Console.WriteLine($"Max: {statistics.Max}");
        //Console.WriteLine("****************************");
    }
}