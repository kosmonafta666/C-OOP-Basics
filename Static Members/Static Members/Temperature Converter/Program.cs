namespace Temperature_Converter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TempCoverter
    {
        public static double CelsiusToFahrenheit(double grads)
        {
            var result = (grads * 1.8) + 32;

            return result;
        }

        public static double FahrenheitToCelsius(double grads)
        {
            var result = (grads - 32) / 1.8;

            return result;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //read the input;
            var input = Console.ReadLine();

            while(input != "End")
            {
                //var for splitted input;
                var token = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for grads;
                var grads = double.Parse(token[0]);

                //var for option to convert;
                var option = token[1];

                //var for result of converting;
                var result = 0.0;

                //check the options;
                if (option == "Celsius")
                {
                    result = TempCoverter.CelsiusToFahrenheit(grads);

                    Console.WriteLine("{0:F2} Fahrenheit", result);
                }
                else if (option == "Fahrenheit")
                {
                    result = TempCoverter.FahrenheitToCelsius(grads);

                    Console.WriteLine("{0:F2} Celsius", result);
                } //end of check the options;      

                input = Console.ReadLine();
            }
        }
    }
}
