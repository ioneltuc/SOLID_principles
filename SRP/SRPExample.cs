namespace TMPS_lab4.SRP
{
    public static class SRPExample
    {
        public static void StartExample()
        {
            var employee1 = new Employee() { FirstName = "Jeff", LastName = "Johnson" };
            var employee2 = new Employee() { FirstName = "Bob", LastName = "Lee" };

            CompanyDB.AddEmployee(employee1);
            CompanyDB.AddEmployee(employee2);
            
            var emailManager = new EmailManager();
            employee1.Email = emailManager.GenerateEmail(employee1.FirstName, employee1.LastName);
            employee2.Email = emailManager.GenerateEmail(employee2.FirstName, employee2.LastName);

            var salaryManager = new SalaryManager();
            employee1.Salary = salaryManager.CalculateSalary(7, 2000);
            employee2.Salary = salaryManager.CalculateSalary(1, 1000);

            CompanyDB.DisplayEmployee();
        }
    }
}