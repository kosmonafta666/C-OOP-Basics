﻿namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Kitten : Animal
    {
        public Kitten(string name, int age)
            :base(name, age, "Female")
        {
        }

        public override string ProduceSound()
        {
            return "Miau";
        }
    }
}
