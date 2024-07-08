namespace OCP.After;
public class JsonInvoiceRepository : IInvoiceRepository
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into a json file.");
    }
}
