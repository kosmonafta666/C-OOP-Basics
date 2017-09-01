namespace Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OpinionPoll
    {
        public static void Main(string[] args)
        {
            //read the number of persons;
            var n = int.Parse(Console.ReadLine());

            //list for persons;
            var persons = new List<Person>();

            for (int i = 1; i <= n; i++)
            {
                //read the current command;
                var currentCommand = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for name of the current person;
                var currentName = currentCommand[0];

                //var for age of the current person;
                var currentAge = int.Parse(currentCommand[1]);

                //create current person;
                var currentPerson = new Person(currentName, currentAge);

                persons.Add(currentPerson);
            }

            //create new list with person with age more than 30;
            var olderPersons = persons
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            //printing the result;
            foreach (var person in olderPersons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
