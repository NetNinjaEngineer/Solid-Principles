namespace ISP.Before
{
    internal class Car : IVehicle
    {
        public void Run() => Console.Write("Running");
        public void Fly() => throw new NotImplementedException();
    }
}
