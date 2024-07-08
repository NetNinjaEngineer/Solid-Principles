/*
The Single Responsibility Principle states that a software module should 
have a single responsibility

 a software module can be a class or a method of a class. 
The responsibility refers to the purpose or concern that a class has 
in an application.

 */

using SRP;


#region Before SRP
var invoice01 = new SRP.Before.Invoice
{
    InvoiceNo = 1,
    Customer = "John Doe",
    IssuedDate = new DateOnly(2023, 4, 1),
    Description = "Website Design",
    Amount = 1000
};

invoice01.Save();

#endregion



#region After SRP
var invoice02 = new Invoice
{
    InvoiceNo = 1,
    Customer = "John Doe",
    IssuedDate = new DateOnly(2023, 4, 1),
    Description = "Website Design",
    Amount = 1000
};

InvoiceRepository repository = new();
repository.Save(invoice02);
#endregion

Console.ReadKey();