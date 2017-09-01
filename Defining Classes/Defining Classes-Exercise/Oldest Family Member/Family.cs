namespace Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Family
    {
        private List<Person> persons;

        public List<Person> Persons
        {
            get { return this.persons; }

            set { this.persons = value; }
        }

        public Family()
        {
            this.Persons = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.Persons.Add(member);
        }

        public Person GetOldestMember()
        {           
            return this.Persons
                .OrderByDescending(x => x)
                .FirstOrDefault();
        }
    }
}
