namespace ISP.After
{
    public class Aircraft : IRunnable, IFlyable
    {
        public void Run() => Console.Write("Running");
        public void Fly() => Console.Write("Flying");
    }
}
