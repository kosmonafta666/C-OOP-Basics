namespace Mankind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHours;

        public decimal WeekSalary
        {
            get { return this.weekSalary; }

            private set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHours
        {
            get { return this.workHours; }

            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHours = value;
            }
        }
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHours)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;

            this.WorkHours = workHours;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            var salaryPerHour = this.WeekSalary / (this.WorkHours * 5);

            result.Append("First Name: ")
                .AppendLine($"{this.FirstName}")
                .Append("Last Name: ")
                .AppendLine($"{this.LastName}")
                .Append("Week Salary: ")
                .AppendLine($"{this.WeekSalary:f2}")
                .Append("Hours per day: ")
                .AppendLine($"{this.WorkHours:f2}")
                .Append("Salary per hour: ")
                .AppendLine($"{salaryPerHour:f2}");

            return result.ToString();
        }
    }
}
