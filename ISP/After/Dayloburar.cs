namespace ISP.After
{
    public class Dayloburar : Employee,
        IHealthInsuranceEntitlement, ITransportationsEntitlement
    {
        public decimal CalculateHealthInsurance() => 300m;
        public decimal CalculateTransportations() => 150m;

        protected override decimal CalculateNetSalary()
        {
            return Salary
                + CalculateHealthInsurance()
                + CalculateTransportations();
        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(Dayloburar)} --- " +
                $"\n No: {EmployeeNo}" +
                $"\n Name: {Name}" +
                $"\n BasicSalary: {Salary:C}" +
                $"\n Health Insurance: {CalculateHealthInsurance():C}" +
                $"\n Transportations: {CalculateTransportations():C}" +
                $"\n ------------------------------------------------" +
                $"\n NetSalary: {CalculateNetSalary():C}";
        }
    }
}
