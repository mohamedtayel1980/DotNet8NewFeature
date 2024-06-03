namespace UsingKeyedServices.Services
{
    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending push notification: " + message);
        }
    }
}
