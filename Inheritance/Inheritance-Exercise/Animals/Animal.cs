namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get { return this.name; }

            protected set
            {
                this.name = value;
            }
        }
        
        public int Age
        {
            get { return this.age; }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        public string Gender
        {
            get { return this.gender; }

            protected set
            {
                if (value != "Female" && value != "Male")
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public  Animal(string name, int age, string gender)
        {
            this.Name = name;

            this.Age = age;

            this.Gender = gender;
        }

        public virtual string ProduceSound()
        {
            return "";
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"{this.GetType().Name}")
                .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                .Append($"{this.ProduceSound()}");

            return result.ToString();
        }
    }
}
