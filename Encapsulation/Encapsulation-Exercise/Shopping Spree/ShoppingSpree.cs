namespace Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    

    public class ShoppingSpree
    {
        public static void Main(string[] args)
        {
            //dictionary for persons;
            var persons = new Dictionary<string, Person>();

            //dictionary for products;
            var products = new Dictionary<string, Product>();

            //read the persons and money;
            var personsLine = Console.ReadLine()
                .Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            //create person and add to persons;
            CreateEntity(personsLine, persons);

            //read the products and money;
            var productsLine = Console.ReadLine()
                .Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            //create product and add to products;
            CreateEntity(productsLine, products);

            //read the input;
            var line = Console.ReadLine();

            while (line != "END")
            {
                //var for splitted line;
                var token = line
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //var for person name;
                var personName = token[0];
                //var for product name;
                var productName = token[1];

                var person = persons[personName];

                var product = products[productName];

                try
                {
                    person.BuyProduct(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException error)
                {
                    Console.WriteLine(error.Message);
                }

                line = Console.ReadLine();
            }//end of while loop;

            foreach (var person in persons.Values)
            {
                Console.WriteLine(person);
            }
        }

        public static void CreateEntity<T>(string[] tokens, Dictionary<string, T> collection)
        {
            for (int i = 0; i < tokens.Length; i += 2)
            {
                //var for name of the object;
                var name = tokens[i];

                //var for money of the object;
                var money = decimal.Parse(tokens[i + 1]);

                try
                {
                    var item = (T)Activator.CreateInstance(typeof(T),
                        new object[]{
                            name,
                            money
                        });

                    //add object to dictionary;
                    collection.Add(name, item);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.InnerException.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
