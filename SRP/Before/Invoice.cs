﻿namespace SRP.Before;
public class Invoice
{
    public int InvoiceNo { get; set; }
    public DateOnly IssuedDate { get; set; }
    public string? Customer { get; set; }
    public decimal Amount { get; set; }
    public string? Description { get; set; }

    public void Save()
    {
        Console.WriteLine($"Saved the invoice #{InvoiceNo}");
    }
}
