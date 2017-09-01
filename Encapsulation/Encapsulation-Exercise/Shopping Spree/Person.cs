namespace Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string name;

        private decimal money;

        private List<Product> products;

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(this.Money)} cannot be negative");
                }

                this.money = value;
            }
        }

        public Person(string name, decimal money)
        {
            this.Name = name;

            this.Money = money;

            this.products = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            if (product.Money > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            this.Money -= product.Money;

            this.products.Add(product);
        }

        public override string ToString()
        {
            string products = string.Join(", ", this.products);

            if (string.IsNullOrEmpty(products))
            {
                products = "Nothing bought";
            }

            var result = $"{this.Name} - {products}";

            return result;
        }
    }

}
