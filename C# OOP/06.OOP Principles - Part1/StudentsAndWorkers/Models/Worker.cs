namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = WorkHoursPerDay;
        }

        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour() => (WeekSalary / Constants.WorkWeek) / WorkHoursPerDay;
    }
}



