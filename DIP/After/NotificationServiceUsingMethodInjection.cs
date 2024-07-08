namespace DIP.After
{
    public class NotificationServiceUsingMethodInjection
    {
        public void Notify(List<IMessageService> messageServices)
        {
            foreach (var message in messageServices)
            {
                message.Send();
            }
        }

    }
}
