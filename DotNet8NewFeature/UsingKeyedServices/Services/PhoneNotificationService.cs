namespace UsingKeyedServices.Services
{
    public class PhoneNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Calling via phone: " + message);
        }
    }
}
