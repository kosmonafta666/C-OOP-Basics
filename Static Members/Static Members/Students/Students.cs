namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public static int counter;

        public string name;

        public Student(string name)
        {
            this.name = name;
            counter++;
        }
    }

    public class Students
    {
        public static void Main(string[] args)
        {
            //read the command;
            var command = Console.ReadLine();

            while (command != "End")
            {
                //var for current studend;
                var student = new Student(command);

                command = Console.ReadLine();
            }

            //print the number of students;
            Console.WriteLine(Student.counter);
        }
    }
}
