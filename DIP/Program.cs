using DIP.After;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             the dependency inversion principle is a specific methodology 
              for loosely coupled software modules.

             High-level modules should not import anything from low-level 
            modules. Both should depend on abstractions (e.g., interfaces).

            Abstractions should not depend on details. 
            Details (concrete implementations) should depend on abstractions.
             
             */

            RunExample01BeforeDIP();
            RunExample02AfterDIP();
            RunExample03AfterDIP();
            RunExample04UsingPropertyInjection();
            RunExample04UsingMethodInjection();

            Console.ReadKey();
        }

        private static void RunExample04UsingMethodInjection()
        {
            Console.WriteLine($"---------------- {nameof(RunExample04UsingMethodInjection)} ----------------");
            foreach (var customer in Repository.Customers)
            {
                var messages = new List<IMessageService>
                {
                    new After.EmailService{ EmailAddress = customer.EmailAddress },
                    new After.SMSService { MobileNo = customer.MobileNo }
                };

                var notificationService = new NotificationServiceUsingMethodInjection();
                notificationService.Notify(messages);
            }
        }

        private static void RunExample04UsingPropertyInjection()
        {
            Console.WriteLine($"---------------- {nameof(RunExample04UsingPropertyInjection)} ----------------");
            foreach (var customer in Repository.Customers)
            {
                var messages = new List<IMessageService>
                {
                    new After.EmailService{ EmailAddress = customer.EmailAddress },
                    new After.SMSService { MobileNo = customer.MobileNo }
                };

                var notificationService = new NotificationServiceUsingPropertyInjection();
                notificationService.SetServices(messages);
                notificationService.Notify();
            }


        }

        private static void RunExample01BeforeDIP()
        {
            Console.WriteLine($"---------------- {nameof(RunExample01BeforeDIP)} ----------------");

            foreach (var customer in Repository.Customers)
            {
                NotificationService notificationService = new(customer);
                notificationService.Notify();
            }

        }

        private static void RunExample02AfterDIP()
        {
            Console.WriteLine($"---------------- {nameof(RunExample02AfterDIP)} ----------------");

            foreach (var customer in Repository.Customers)
            {
                var notificationService = new After.NotificationService(new After.EmailService
                {
                    EmailAddress = customer.EmailAddress
                });

                notificationService.Notify();
            }

        }

        private static void RunExample03AfterDIP()
        {
            Console.WriteLine($"---------------- {nameof(RunExample03AfterDIP)} ----------------");

            foreach (var customer in Repository.Customers)
            {
                var notificationServices = new List<IMessageService>
                {
                    new After.EmailService{ EmailAddress = customer.EmailAddress},
                    new After.SMSService { MobileNo  = customer.MobileNo }
                };

                var service = new After.NotificationService(notificationServices);
                service.NotifyAll();

            }

        }
    }
}
