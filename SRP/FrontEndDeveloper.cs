namespace TMPS_lab4.SRP
{
    public class FrontEndDeveloper
    {
        public void GetFrontendInterviewResult(int correctAnswers)
        {
            int totalQuestions = 7;
            int resultInPercentage = (correctAnswers * 100) / totalQuestions;

            if (resultInPercentage > 70)
            {
                Console.WriteLine("The test result is good.");
            }
            else if (resultInPercentage < 30)
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