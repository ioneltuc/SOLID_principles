namespace TMPS_lab4.SRP_violation
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; } = 1000;
        public static List<Employee> Employees { get; set; }
        public Employee()
        {
            Employees = new List<Employee>();
        }

        public void GenerateEmail()
        {
            Email = $"{LastName}.{FirstName}@work.it.com".ToLower();
        }

        public void CalculateSalary(int yearsOfExperience)
        {
            if (yearsOfExperience >= 1 && yearsOfExperience < 2)
            {
                Salary += 500;
            }
            else if (yearsOfExperience >= 2 && yearsOfExperience < 5)
            {
                Salary += 1000;
            }
            else if (yearsOfExperience >= 5)
            {
                Salary += 2000;
            }
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
    }
}