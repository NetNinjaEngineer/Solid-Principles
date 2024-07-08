namespace LSP.After
{
    public abstract class RegularAccount(string? name, decimal balance) 
        : Account(name, balance)
    {
        public abstract void WithDraw(decimal amount);
    }
}
