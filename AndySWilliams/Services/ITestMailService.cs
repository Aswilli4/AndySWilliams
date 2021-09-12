namespace AndySWilliams.Services
{
    public interface ITestMailService
    {
        void SendEmailMessage(string emailTo, string emailSubject, string emailBody);
    }
}