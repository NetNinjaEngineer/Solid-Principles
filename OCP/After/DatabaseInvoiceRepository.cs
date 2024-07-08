namespace OCP.After;
public class DatabaseInvoiceRepository : IInvoiceRepository
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into a database.");
    }
}
