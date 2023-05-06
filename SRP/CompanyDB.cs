namespace TMPS_lab4.SRP
{
    public static class CompanyDB
    {
        private static List<Employee> Employees = new List<Employee>();

        public static void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public static void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public static void DisplayEmployee()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}:");
                Console.WriteLine($"\tEmail: {emp.Email}");
                Console.WriteLine($"\tSalary: {emp.Salary}");
            }
        }
    }
}