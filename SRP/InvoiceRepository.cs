namespace SRP;
public class InvoiceRepository
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine($"Saved invoice #{invoice.InvoiceNo}");
    }
}
