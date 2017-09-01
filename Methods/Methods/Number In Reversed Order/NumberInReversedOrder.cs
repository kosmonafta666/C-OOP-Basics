namespace Number_In_Reversed_Order
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DecimalNumber
    {
        public double number;

        public DecimalNumber(double number)
        {
            this.number = number;
        }

        public double ReverseNumber()
        {
            var stringNumber = new char[this.number.ToString().Length];

            var result = 0.0;

            for (int i = this.number.ToString().Length - 1; i >= 0; i--)
            {
                stringNumber[(this.number.ToString().Length - 1) - i] = this.number.ToString()[i];
            }

            result = double.Parse(new string(stringNumber));

            return result;
        }
    }

    public class NumberInReversedOrder
    {
        public static void Main(string[] args)
        {
            //read the number;
            var number = double.Parse(Console.ReadLine());

            //var for decimal number object and create it;
            var decimalNumber = new DecimalNumber(number);

            //var for reverse decimal number;
            var reverseNumber = decimalNumber.ReverseNumber();

            //print it;
            Console.WriteLine(reverseNumber);
        }
    }
}
