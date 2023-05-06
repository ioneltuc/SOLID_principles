namespace TMPS_lab4.SRP
{
    public class EmailManager : IEmail
    {
        public string GenerateEmail(string firstName, string lastName)
        {
            return $"{lastName}.{firstName}@work.it.com".ToLower();
        }
    }
}