namespace Mankind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get { return this.facultyNumber; }

            private set
            {
                if ( (value.Length < 5 || value.Length > 10) || !value.All(x => char.IsLetterOrDigit(x)) )
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber)
            :base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append("First Name: ")
                .AppendLine($"{this.FirstName}")
                .Append("Last Name: ")
                .AppendLine($"{this.LastName}")
                .Append("Faculty number: ")
                .AppendLine($"{this.FacultyNumber}");

            return result.ToString();
        }
    }
}
