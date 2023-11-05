namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Employee employee = new Employee();
            employee.Salary = -5;
            
            Console.WriteLine($"employee salary {employee.Salary}");


            Human human = new Human();
            human.Message2();
        }
    }
}

// access modifiers 
// pillars of oops 
