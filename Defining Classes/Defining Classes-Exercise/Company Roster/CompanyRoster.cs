namespace Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CompanyRoster
    {
        public static void Main(string[] args)
        {
            //read the number of inputs
            var n = int.Parse(Console.ReadLine());

            //list for employees;
            var employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                //read the current command;
                var currentCommand = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

               //create current employee;
               var currentEmployee = new Employee(
                        currentCommand[0],
                        decimal.Parse(currentCommand[1]),
                        currentCommand[2],
                        currentCommand[3]
                        );

               if (currentCommand.Length > 5)
               {
                    currentEmployee.Age = int.Parse(currentCommand[5]);
               }
               
               if (currentCommand.Length > 4)
               {
                    if (currentCommand[4].Contains("@")) 
                    {
                        currentEmployee.Email = currentCommand[4];
                    }
                    else
                    {
                        currentEmployee.Age = int.Parse(currentCommand[4]);
                    }
               }     

               employees.Add(currentEmployee);
            }

            //group employee by department;
            var groupDepartment = employees.
                GroupBy(x => x.Department)
                .Select(x => new
                {
                    Deparment = x.Key,
                    AverageSalary = x.Average(d => d.Salary),
                    Employe = x.OrderByDescending(e => e.Salary)
                })
                .OrderByDescending(x => x.AverageSalary)
                .FirstOrDefault();

            //printing the result;
            Console.WriteLine("Highest Average Salary: {0}", groupDepartment.Deparment);

            foreach (var employee in groupDepartment.Employe)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
