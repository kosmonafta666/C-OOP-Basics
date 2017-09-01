namespace Date_Modifier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    class DateModifier
    {
        private int differenceDays;

        public int DifferenceDays
        {
            get { return this.differenceDays; }

            private set { this.differenceDays = value; }
        }

        public void DifferenceDate (string date1, string date2)
        {
            DateTime firstDate = DateTime.ParseExact(date1, "yyyy MM dd", CultureInfo.InvariantCulture);

            DateTime secondDate = DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.InvariantCulture);

            TimeSpan difference = firstDate - secondDate;

            this.DifferenceDays = (int)difference.TotalDays;
        }
    }
}
