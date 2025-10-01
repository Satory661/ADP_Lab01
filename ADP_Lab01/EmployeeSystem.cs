namespace ADP_Lab01;

public class EmployeeSystem
{
    private readonly List<Person> _people = new();

    public void Add(Person person)
    {
        _people.Add(person);
        Console.WriteLine($"{person.Name} was added to the system.");
    }

    public void ShowSalaries()
    {
        Console.WriteLine("\nSalary report:");
        foreach (var p in _people)
        {
            Console.WriteLine($"{p.Role} {p.Name}: {p.Salary()}");
        }
    }
}