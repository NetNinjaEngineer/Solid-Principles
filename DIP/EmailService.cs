namespace DIP
{
    internal class EmailService
    {
        public string? EmailAddress { get; set; }

        public void Send()
        {
            Console.WriteLine($"Email is sent to {EmailAddress}");
        }
    }
}
