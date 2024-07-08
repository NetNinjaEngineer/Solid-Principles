internal class Program
{
    static void Main(string[] args)
    {
        /*
        The Liskov substitution principle states that if a method uses a base class,
        then it should be able to use any of its derived classes without the need of
        having the information about the derived class.
         */

        //var account = new LSP.Before.FixedDepositAccount("Mohamed", 1000);
        //account.WithDraw(1000);

        var account = new LSP.After.FixedDepositAccount("Mohamed ElHelaly", 5000);
        account.Deposit(1000);
        Console.WriteLine(account.Balance);

        Console.ReadKey();
    }
}