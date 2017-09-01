﻿namespace Book_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price)
            :base(author, title, price)
        {
        }

        public override decimal Price
        {
            get => base.Price * 1.3m;

            protected set => base.Price = value;
        }
    }
}
