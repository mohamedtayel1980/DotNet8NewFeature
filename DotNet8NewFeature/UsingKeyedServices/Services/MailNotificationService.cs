namespace UsingKeyedServices.Services
{
    public class MailNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending mail: " + message);
        }
    }
}
