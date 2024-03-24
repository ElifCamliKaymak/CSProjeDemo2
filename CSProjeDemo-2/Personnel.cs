namespace CSProjeDemo_2
{
    public abstract class Personnel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{FirstName} {Surname}";
        public virtual int WorkingHour { get; set; }
        public virtual double HourlyRate { get; set; }
        public double Salary { get; set; }
        public virtual double CalculateSalary()
        {
            Salary = WorkingHour * HourlyRate;
            return Salary;
        }
    }
}
