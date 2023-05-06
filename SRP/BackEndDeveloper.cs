namespace TMPS_lab4.SRP
{
    public class BackEndDeveloper
    {
        public void GetBackendInterviewResult(int correctAnswers)
        {
            int totalQuestions = 12;
            int resultInPercentage = (correctAnswers * 100) / totalQuestions;

            if (resultInPercentage > 60)
            {
                Console.WriteLine("The test result is good.");
            }
            else if (resultInPercentage < 40)
            {
                Console.WriteLine("The test result is bad.");
            }
            else
            {
                Console.WriteLine("The test result is average.");
            }
        }
    }
}