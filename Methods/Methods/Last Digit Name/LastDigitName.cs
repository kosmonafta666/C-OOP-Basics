namespace Last_Digit_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Number
    {
        public int number;

        public Number(int number)
        {
            this.number = number;
        }

        public string LastDigit()
        {
            string result = "";

            var lastDigit = this.number % 10;

            switch(lastDigit)
            {
                case 0:
                    result = "zero";
                    break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }

            return result;
        }
    }

    public class LastDigitName
    {
        public static void Main(string[] args)
        {
            //read the number;
            var number = int.Parse(Console.ReadLine());

            //create number object;
            var intNumber = new Number(number);

            Console.WriteLine(intNumber.LastDigit());
        }
    }
}
