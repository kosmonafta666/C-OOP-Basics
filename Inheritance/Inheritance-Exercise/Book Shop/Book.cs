namespace Book_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public string Title
        {
            get { return this.title; }

            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get { return this.author; }

            protected set
            {
                if (value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length > 1)
                {
                    var secondName = value.Split(' ')[1];

                    bool isDigit = char.IsDigit(secondName[0]);

                    if (isDigit)
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }              

                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }

            protected set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            this.Author = author;

            this.Title = title;          

            this.Price = price;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return result.ToString();
        }
    }
}
