using ChallengeApp;

List<Employee> employees = new List<Employee>();
employees.Add(new Employee("Adam", "Kowalski", 35));
employees.Add(new Employee("Kasia", "Nowak", 22));
employees.Add(new Employee("Jola", "Woźniak", 50));

//int newGrade;
//Random random = new();
foreach (var employee in employees)
{
    Console.WriteLine($"{employee.Name} {employee.Surname} ({employee.Age})");
    //for (int i = 0; i < random.Next(0, 10); i++)
    //{
    //    newGrade = random.Next(0, 101);
    //    Console.WriteLine(newGrade);
    //    employee.AddGrade(newGrade);
    //}
    Console.WriteLine("-----------------------");
    employee.AddGrade("20,1");
    Console.WriteLine("-----------------------");
    employee.AddGrade(1);
    Console.WriteLine("-----------------------");
    employee.AddGrade(0.423e-40);
    Console.WriteLine("-----------------------");
    employee.AddGrade(10.555f);
    Console.WriteLine("-----------------------");
    employee.AddGrade(1.5654E1m);
    Console.WriteLine("-----------------------");
    employee.AddGrade(long.MaxValue);
    Console.WriteLine("-----------------------");
    employee.AddGrade(decimal.MaxValue);
    Console.WriteLine("-----------------------");
    employee.AddGrade(double.MaxValue);
    Console.WriteLine("-----------------------");
    employee.AddGrade(int.MaxValue);
    Console.WriteLine("-----------------------");


    var statistics = employee.GetStatistics();
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine("****************************");
    break;
}


