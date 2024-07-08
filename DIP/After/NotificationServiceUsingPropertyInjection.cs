namespace DIP.After
{
    public class NotificationServiceUsingPropertyInjection
    {
        public List<IMessageService> MessageServices { get; private set; } = [];

        public void SetServices(List<IMessageService> messageServices)
        {
            MessageServices = messageServices;
        }

        public void Notify()
        {
            foreach (var message in MessageServices)
            {
                message.Send();
            }
        }

    }
}
