namespace ADP_Lab01;

public class Manager : Person
{
    public decimal BasePay { get; }
    public decimal Bonus { get; }

    public Manager(string name, int id, string role, decimal basePay, decimal bonus) 
        : base(name, id, role)
    {
        BasePay = basePay;
        Bonus = bonus;
    }

    public override decimal Salary()
    {
        return BasePay + Bonus;
    }
}
