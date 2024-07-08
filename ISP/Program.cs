using ISP.Before;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunExample02BeforeISP();
            RunExample02AfterISP();

            Console.ReadKey();
        }

        private static void RunExample01()
        {
            //// aircraft 
            //var aircraft = new ISP.Before.Aircraft();
            //aircraft.Run();
            //aircraft.Fly();

            //// car
            //var car = new ISP.Before.Car();
            //car.Run();

            //// cannot fly, exception
            //car.Fly();

            var car = new ISP.After.Car();
            car.Run();

            var aircraft = new ISP.After.Aircraft();
            aircraft.Run();
            aircraft.Fly();
        }

        private static void RunExample02BeforeISP()
        {
            var employees = Repository.GetEmployees();

            foreach (var employee in employees)
                Console.WriteLine(employee.PrintSalarySlip());
        }

        private static void RunExample02AfterISP()
        {
            var employees = After.Repository.GetEmployees();

            foreach (var employee in employees)
                Console.WriteLine(employee.PrintSalarySlip());

        }
    }
}
