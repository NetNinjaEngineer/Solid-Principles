using ISP.Before;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             In the field of software engineering, the interface segregation 
            principle (ISP) states that no code should be forced to depend on 
            methods it does not use.[1] ISP splits interfaces that are very 
            large into smaller and more specific ones so that clients will only 
            have to know about the methods that are of interest to them
             */

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
