namespace TMPS_lab4.SRP
{
    public class SalaryManager : ISalary
    {
        public double CalculateSalary(int yearsOfExperience, double salary)
        {
            if (yearsOfExperience >= 1 && yearsOfExperience < 2)
            {
                return salary + 500;
            }
            else if (yearsOfExperience >= 2 && yearsOfExperience < 5)
            {
                return salary + 1000;
            }
            else if (yearsOfExperience >= 5)
            {
                return salary + 2000;
            }

            return salary;
        }
    }
}