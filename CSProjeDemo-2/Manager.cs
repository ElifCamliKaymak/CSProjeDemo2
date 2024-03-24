namespace CSProjeDemo_2
{
    public class Manager : Personnel
    {
        private const double MinSalary = 500;
        private double Prim { get; set; }
        public override double CalculateSalary()
        {
            double salary = WorkingHour * HourlyRate;
            if (salary < MinSalary)
            {
                salary = MinSalary;
            }
            salary += Prim;
            return salary;
        }
    }
}
