namespace OCP.After;
public class FileInvoiceRepository : IInvoiceRepository
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into a file.");
    }
}
