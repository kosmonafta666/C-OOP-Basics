namespace Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string name;

        private int age;

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { age = value; }
        }

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
