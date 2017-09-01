namespace Unique_Student_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public static HashSet<string> uniqueNames;

        public string name;

        public Student (string name)
        {
            this.name = name;
            uniqueNames.Add(name);
        }

        static Student ()
        {
            uniqueNames = new HashSet<string>();
        }
    }

    public class UniqueStudentNames
    {
        public static void Main(string[] args)
        {
            //var for command;
            var command = Console.ReadLine();

            while (command != "End")
            {
                //var for current student;
                var currentStudent = new Student(command);

                command = Console.ReadLine();
            }//end of while loop;

            //print the result;
            Console.WriteLine(Student.uniqueNames.Count);
        }
    }
}
