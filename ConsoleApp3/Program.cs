namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Employee> employees = new List<Employee>()
            {
                new ManagerEmployee(){},
                new ContractEmployee() {},
                new OfficeBoyEmployee() {}
            };

            foreach (Employee employee in employees)
            {
                employee.CalculateTotalSalary();
            }
        }
    }
}