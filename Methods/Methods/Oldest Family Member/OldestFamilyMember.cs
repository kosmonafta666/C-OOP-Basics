namespace Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        public string name;

        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Family
    {
        public List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            var oldestPerson = this.people
                .OrderByDescending(x => x.age)
                .FirstOrDefault();

            return oldestPerson;
        }
    }
    

    public class OldestFamilyMember
    {
        public static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            //read the number of persons;
            var n = int.Parse(Console.ReadLine());

            //var for the family object;
            var family = new Family();

            for (int i = 1; i <= n; i++)
            {
                //read the current person;
                var personInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for name of the current person;
                var name = personInfo[0];
                //var for the age of the current person;
                var age = int.Parse(personInfo[1]);

                //var for current person and create it;
                var currentPerson = new Person(name, age);

                //add current person to family;
                family.AddMember(currentPerson);
            }

            //get oldest family member;
            var oldestFamilyPerson = family.GetOldestMember();

            //print the result;
            Console.Write("{0} ", oldestFamilyPerson.name);
            Console.Write(oldestFamilyPerson.age);
        }
    }
}
