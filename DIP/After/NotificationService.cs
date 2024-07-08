namespace DIP.After;

internal class NotificationService
{
    private readonly IMessageService? _messageService;
    private readonly ICollection<IMessageService>? _messageServices;

    public NotificationService(IMessageService? messageService)
    {
        _messageService = messageService;
    }

    public NotificationService(ICollection<IMessageService>? messageServices)
    {
        _messageServices = messageServices;
    }

    public void Notify()
    {
        _messageService?.Send();
    }

    public void NotifyAll()
    {
        foreach (var message in _messageServices!)
        {
            message.Send();
        }
    }
}
