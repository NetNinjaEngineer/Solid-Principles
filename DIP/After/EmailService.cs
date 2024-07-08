namespace DIP.After;

internal class EmailService : IMessageService
{
    public string? EmailAddress { get; set; }

    public void Send()
    {
        Console.WriteLine($"Email is sent to {EmailAddress}");
    }
}
