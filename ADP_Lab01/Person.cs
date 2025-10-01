namespace ADP_Lab01;

public abstract class Person
{
    public string Name { get; }
    public int Id { get; }
    public string Role { get; }

    protected Person(string name, int id, string role)
    {
        Name = name;
        Id = id;
        Role = role;
    }

    public abstract decimal Salary();
}