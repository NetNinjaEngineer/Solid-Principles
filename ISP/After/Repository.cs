namespace ISP.After
{
    public static class Repository
    {
        public static List<Employee> GetEmployees()
        {
            return new()
            {
                new Consultant
                {
                    EmployeeNo = 1,
                    Name = "Mohamed Ehab",
                    Salary = 10500
                },
                new Staff
                {
                    EmployeeNo = 2,
                    Name = "Noha Salem",
                    Salary = 5800
                },
                new Dayloburar
                {
                    EmployeeNo = 3,
                    Name = "Khalid Saeed",
                    Salary = 8600
                }
            };
        }
    }
}
