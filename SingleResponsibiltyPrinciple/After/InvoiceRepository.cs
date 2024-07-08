namespace SRP.After;
public class InvoiceRepository(Invoice invoice)
{
    public void Save()
        => Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo}");
}
