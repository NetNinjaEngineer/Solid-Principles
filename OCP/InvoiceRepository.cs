/*
 Open-closed principle states that software entities (classes, methods, 
functions, etc.) should be open for extension but closed for modification.
 */


using OCP;

public class InvoiceRepository
{
    public void SaveFile(Invoice invoice)
    {
        Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into a file.");
    }

    public void SaveDB(Invoice invoice)
    {
        Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into a database.");
    }

    public void SaveJson(Invoice invoice)
    {
        Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into a json file.");
    }
}