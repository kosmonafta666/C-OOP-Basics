namespace Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        private const int MinWeight = 1;
        private const int MaxWeight = 200;

        public string FlourType
        {
            get { return this.flourType; }

            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return this.bakingTechnique; }

            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }

            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                }

                this.weight = value;
            }
        }

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;

            this.BakingTechnique = bakingTechnique;

            this.Weight = weight;
        }

        public double GetCalories()
        {
            return (this.weight * 2) * this.GetTypeMod() * this.GetBakingMod();
        }

        private double GetTypeMod()
        {
            double result = 0;

            switch(this.FlourType.ToLower())
            {
                case "white":
                    result =  1.5;
                    break;
                case "wholegrain":
                    result = 1.0;
                    break;
            }

            return result;
        }

        private double GetBakingMod()
        {
            double result = 0;

            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    result = 0.9;
                    break;
                case "chewy":
                    result = 1.1;
                    break;
                case "homemade":
                    result = 1.0;
                    break;
            }

            return result;
        }
    }
}
