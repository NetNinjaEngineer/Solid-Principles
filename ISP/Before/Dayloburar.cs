namespace ISP.Before
{
    public class Dayloburar : Employee, IEntitlement
    {
        public decimal CalculateBonuses()
            => throw new NotImplementedException("Dayloburar bonuses not supported");

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension()
            => throw new NotImplementedException("Dayloburar pension not supported");

        public decimal CalculateRentalSubsidy()
            => throw new NotImplementedException("Dayloburar rental subsidy not supported");


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
