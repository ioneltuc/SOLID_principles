namespace TMPS_lab4.SRP
{
    public interface IEmail
    {
        string GenerateEmail(string firstName, string lastName);
    }
}