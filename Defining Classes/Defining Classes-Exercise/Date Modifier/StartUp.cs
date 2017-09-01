namespace Date_Modifier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //read the first date;
            var firstDate = Console.ReadLine();

            //read the second date;
            var secondDate = Console.ReadLine();

            //DateModifier object;
            var dateModifier = new DateModifier();

            //calculate the difference between dates;
            dateModifier.DifferenceDate(firstDate, secondDate);

            //print it;
            Console.WriteLine(Math.Abs(dateModifier.DifferenceDays));
        }
    }
}
