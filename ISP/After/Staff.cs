namespace ISP.After
{
    public class Staff : Employee,
        IBonusesEntitlement,
        IHealthInsuranceEntitlement,
        IPensionEntitlement,
        IRentalSubsidyEntitlement
    {
        public decimal CalculateBonuses() => Salary * 0.05m;
        public decimal CalculateHealthInsurance() => 300m;
        public decimal CalculatePension() => 0.025m * Salary;
        public decimal CalculateRentalSubsidy() => 150m;

        protected override decimal CalculateNetSalary()
        {
            return Salary
                + CalculateHealthInsurance()
                + CalculateRentalSubsidy()
                + CalculateBonuses()
                + CalculatePension();
        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(Staff)} --- " +
                $"\n No: {EmployeeNo}" +
                $"\n Name: {Name}" +
                $"\n BasicSalary: {Salary:C}" +
                $"\n Health Insurance: {CalculateHealthInsurance():C}" +
                $"\n Pension: {CalculatePension():C}" +
                $"\n RentalSubsidy: {CalculateRentalSubsidy():C}" +
                $"\n ------------------------------------------------" +
                $"\n NetSalary: {CalculateNetSalary():C}";
        }
    }
}
