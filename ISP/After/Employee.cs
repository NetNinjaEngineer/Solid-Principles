namespace ISP.After
{
    public abstract class Employee
    {
        public int EmployeeNo { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        protected abstract decimal CalculateNetSalary();

        public abstract string PrintSalarySlip();

    }
}
