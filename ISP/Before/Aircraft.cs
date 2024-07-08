namespace ISP.Before
{
    public class Aircraft : IVehicle
    {
        public void Run() => Console.Write("Running");
        public void Fly() => Console.Write("Flying");
    }
}
