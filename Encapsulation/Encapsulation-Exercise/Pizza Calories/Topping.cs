namespace Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Topping
    {
        private string type;
        private double weight;

        private const int MinWeight = 1;
        private const int MaxWeight = 50;

        public string Type
        {
            get { return this.type; }

            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" 
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }

            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public Topping(string type, double weight)
        {
            this.Type = type;

            this.Weight = weight;
        }

        public double GetCalories()
        {
            return (this.Weight * 2) * GetTypeMod();
        }

        private double GetTypeMod()
        {
            double result = 0;

            switch (this.Type.ToLower())
            {
                case "meat":
                    result = 1.2;
                    break;
                case "veggies":
                    result = 0.8;
                    break;
                case "cheese":
                    result = 1.1;
                    break;
                case "sauce":
                    result = 0.9;
                    break;
            }

            return result;
        }
    }
}
