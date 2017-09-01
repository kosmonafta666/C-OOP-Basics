namespace Pizza_Time
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class Pizza
    {
        public static List<Pizza> pizzas = new List<Pizza>();

        public string name;

        public int group;

        public Pizza(string name, int group)
        {
            this.name = name;
            this.group = group;
            pizzas.Add(this);
        }

        public static SortedDictionary<int, List<string>> OurDictionary(string [] pizzasName)
        {
            var sortedPizzas = new SortedDictionary<int, List<string>>();

            foreach (var str in pizzasName)
            {
                var pizza = pizzas
                    .Where(x => x.name == str)
                    .FirstOrDefault();

                var key = pizza.group;
                var name = pizza.name;

                if (!sortedPizzas.ContainsKey(key))
                {
                    sortedPizzas.Add(key, new List<string>());
                    sortedPizzas[key].Add(name);
                }
                else
                {
                    sortedPizzas[key].Add(name);
                }
            }

            return sortedPizzas;
        }
    }

    public class PizzaTime
    {
        public static void Main(string[] args)
        {
            MethodInfo[] methods = typeof(Pizza).GetMethods();
            bool containsMethod = methods.Any(m => m.ReturnType.Name.Contains("SortedDictionary"));
            if (!containsMethod)
            {
                throw new Exception();
            }

            //read the input;
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            //regex to extract pizza name and group;
            var regex = new Regex(@"(\d+)(\w+)");

            //array for pizzas;
            string[] pizzasName = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                //match for current pizza;
                Match match = regex.Match(input[i]);

                //var for pizza group;
                var pizzaGroup = int.Parse(match.Groups[1].Value);
                //var for pizza name;
                var pizzaName = match.Groups[2].Value;

                //var for current pizza;
                var currentPizza = new Pizza(pizzaName, pizzaGroup);

                //add current pizza to pizzas array;
                pizzasName[i] = pizzaName;
            }

            //sorted dictionary for pizzas by group;
            var sorted = Pizza.OurDictionary(pizzasName);

            //printing the result;
            foreach (var pizza in sorted)
            {
                Console.Write("{0} - ", pizza.Key);
                Console.WriteLine("{0}", string.Join(", ", pizza.Value));
            }
        }
    }
}
