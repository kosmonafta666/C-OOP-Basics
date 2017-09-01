namespace Mordor_s_Cruelty_Plan.Models.Foods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cram : Food
    {
        private const int HapinessPoints = 2;

        public Cram()
            :base(HapinessPoints)
        {
        }
    }
}
