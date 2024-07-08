namespace ISP.After
{
    public class Consultant : Employee,
        IBonusesEntitlement,
        IHealthInsuranceEntitlement,
        ITransportationsEntitlement
    {
        public decimal CalculateBonuses() => Salary * 0.05m;
        public decimal CalculateHealthInsurance() => 300m;
        public decimal CalculateTransportations() => 150m;

        protected override decimal CalculateNetSalary()
        {
            return Salary
                + CalculateHealthInsurance()
                + CalculateTransportations()
                + CalculateBonuses();
        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(Consultant)} --- " +
                $"\n No: {EmployeeNo}" +
                $"\n Name: {Name}" +
                $"\n BasicSalary: {Salary:C}" +
                $"\n Health Insurance: {CalculateHealthInsurance():C}" +
                $"\n Transportations: {CalculateTransportations():C}" +
                $"\n Bonus: {CalculateBonuses():C}" +
                $"\n ------------------------------------------------" +
                $"\n NetSalary: {CalculateNetSalary():C}";
        }
    }
}
