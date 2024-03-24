namespace CSProjeDemo_2
{
    public class Officer : Personnel
    {
        private const int MaxWorkingHour = 180;
        private const double OvertimeCoefficient = 1.5;
        public override double HourlyRate { get; set; } = 500;
        public override double CalculateSalary()
        {
            double salary;
            if (WorkingHour <= MaxWorkingHour)
            {
                salary = WorkingHour * HourlyRate;
            }
            else
            {
                int overwork = WorkingHour - MaxWorkingHour;
                salary = (MaxWorkingHour * HourlyRate) + (overwork * HourlyRate * OvertimeCoefficient);
            }
            return salary;
        }
    }
}
