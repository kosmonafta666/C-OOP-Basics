namespace Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private int numberOfToppings;

        public string Name
        {
            get { return this.name; }

            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int NumberOfToppings
        {
            get { return this.numberOfToppings; }

            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.numberOfToppings = value;
            }
        }

        public Dough Dough
        {
            set { this.dough = value; }
        }

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;

            this.NumberOfToppings = numberOfToppings;

            this.toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
        }

        public double GetCalories()
        {        
            return this.dough.GetCalories() + this.toppings.Sum(x => x.GetCalories());          
        }
    }
}
