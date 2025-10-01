namespace ADP_Lab01;

public class Worker : Person
{
    public decimal Rate { get; }
    public int Hours { get; }

    public Worker(string name, int id, string role, decimal rate, int hours) 
        : base(name, id, role)
    {
        Rate = rate;
        Hours = hours;
    }

    public override decimal Salary()
    {
        return Rate * Hours;
    }
}