namespace Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

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

            //read teh number of persons;
            var n = int.Parse(Console.ReadLine());

            //var for new family object;
            var family = new Family();

            for (int i = 1; i <= n; i++)
            {
                //read the current input;
                var token = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                //var for person name;
                var name = token[0];

                //var for person age;
                var age = int.Parse(token[1]);

                //create new current person;
                var currentPerson = new Person()
                {
                    name = name,
                    age = age
                };

                //add current person to family;
                family.AddMember(currentPerson);                
            }

            //print the result;
            Console.WriteLine("{0} {1}", family.GetOldestMember().name, family.GetOldestMember().age);
        }
    }
}
