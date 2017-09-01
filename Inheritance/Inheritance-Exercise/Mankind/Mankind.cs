namespace Mankind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mankind
    {
        public static void Main(string[] args)
        {
            try
            {
                //read the student;
                var studentLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //var for student first name;
                var studentFirstName = studentLine[0];
                //var for student last name;
                var studentLastName = studentLine[1];
                //var for student faculty number;
                var studentNumber = studentLine[2];

                //create student;
                var student = new Student(studentFirstName, studentLastName, studentNumber);

                //read the worker;
                var workerLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //var for worker first name;
                var workerFirstName = workerLine[0];
                //var for worker last name;
                var workerLastName = workerLine[1];
                //var for worker week salary;
                var weekSalary = decimal.Parse(workerLine[2]);
                //var for worker hour per day;
                var hoursPerDay = decimal.Parse(workerLine[3]);

                //create worker;
                var worker = new Worker(workerFirstName, workerLastName, weekSalary, hoursPerDay);

                //print the student;
                Console.WriteLine(student);
                //print the worker;
                Console.WriteLine(worker);
            }
            catch(ArgumentException er)
            {
                Console.WriteLine(er.Message);
            }
        }
    }
}
