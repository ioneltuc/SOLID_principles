namespace TMPS_lab4.SRP_violation
{
    public static class SRPViolationExample
    {
        public static void StartExample()
        {
            var employee1 = new Employee() { FirstName = "Jeff", LastName = "Johnson" };
            var employee2 = new Employee() { FirstName = "Bob", LastName = "Lee" };
            Employee.Employees.Add(employee1);
            Employee.Employees.Add(employee2);
            employee1.GenerateEmail();
            Console.WriteLine($"Employee: {employee1.FirstName} {employee1.LastName}");
            Console.WriteLine("Email: " + employee1.Email);
            employee1.CalculateSalary(7);
            Console.WriteLine("Salary: " + employee1.Salary);
        }
    }
}