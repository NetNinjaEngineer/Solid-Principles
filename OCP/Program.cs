/*
 Open-closed principle states that software entities (classes, methods, 
functions, etc.) should be open for extension but closed for modification.
 */

#region Before OCP
using OCP.After;

var invoice1 = new OCP.Invoice
{
    InvoiceNo = 1,
    Customer = "John Doe",
    IssuedDate = new DateOnly(2023, 4, 1),
    Description = "Website Design",
    Amount = 1000
};


var invoiceRepository = new InvoiceRepository();
invoiceRepository.SaveFile(invoice1);
invoiceRepository.SaveDB(invoice1);
invoiceRepository.SaveJson(invoice1);

#endregion

#region After OCP
var invoice2 = new OCP.After.Invoice
{
    InvoiceNo = 1,
    Customer = "John Doe",
    IssuedDate = new DateOnly(2023, 4, 1),
    Description = "Website Design",
    Amount = 1000
};

IInvoiceRepository repository = new FileInvoiceRepository();
repository.Save(invoice2);

repository = new DatabaseInvoiceRepository();
repository.Save(invoice2);

repository = new JsonInvoiceRepository();
repository.Save(invoice2);

#endregion

Console.ReadKey();