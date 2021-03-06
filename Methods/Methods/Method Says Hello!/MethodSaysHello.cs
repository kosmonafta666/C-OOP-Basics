﻿namespace Method_Says_Hello_
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

        public Person(string name)
        {
            this.name = name;
        }

        public string SayHello()
        {
            string result = ($"{this.name} says \"Hello\"!");

            return result;
        }
    }

    public class MethodSaysHello
    {
        public static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] methods = personType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            if (fields.Length != 1 || methods.Length != 5)
            {
                throw new Exception();
            }

            string personName = Console.ReadLine();
            Person person = new Person(personName);

            Console.WriteLine(person.SayHello());
        }
    }
}
