﻿namespace Person
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

        public virtual string Name
        {
            get { return this.name; }

            set
            {
                if (value.Length < 3 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }

                this.name = value;
            }
        }

        public virtual int Age
        {
            get { return this.age; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                this.age = value;
            }
        }

        public Person (string name, int age)
        {
            this.Name = name;

            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));

            return result.ToString();
        }
    }
}

