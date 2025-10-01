namespace ADP_Lab01;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeSystem system = new EmployeeSystem();

        Manager manager = new Manager("Ivan Petrov", 101, "Manager", 350000, 20000);
        Worker worker1 = new Worker("Anna Smirnova", 102, "Developer", 6000, 38);
        Worker worker2 = new Worker("Sergey Ivanov", 103, "QA Engineer", 4500, 42);
        Worker worker3 = new Worker("Olga Sidorova", 104, "Designer", 5200, 36);

        system.Add(manager);
        system.Add(worker1);
        system.Add(worker2);
        system.Add(worker3);

        system.ShowSalaries();
    }
}