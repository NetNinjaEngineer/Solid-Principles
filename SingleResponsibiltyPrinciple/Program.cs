﻿/*
    The Single Responsibility Principle states that a software module 
    should have a single responsibility
    a software module can be a class or a method of a class. 
    The responsibility refers to the purpose or concern that a class 
    has in an application.
 */

using SingleResponsibiltyPrinciple.After;

var invoice01 = new SingleResponsibiltyPrinciple.Before.Invoice
{
    InvoiceNo = 1,
    Customer = "John Doe",
    IssuedDate = new DateOnly(2023, 4, 1),
    Description = "Website Design",
    Amount = 1000
};

invoice01.Save();

Invoice invoice02 = new()
{
    InvoiceNo = 2,
    Customer = "John Doe",
    IssuedDate = new DateOnly(2023, 4, 1),
    Description = "Website Design",
    Amount = 2000
};

InvoiceRepository repository = new(invoice02);
repository.Save();


Console.ReadKey();