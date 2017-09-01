namespace Mordor_s_Cruelty_Plan.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Food
    {
        private int HapinessPoints
        {
            get; set;
        }

        protected Food(int hapinessPoints)
        {
            this.HapinessPoints = hapinessPoints;
        }

        public int GetHapinessPoints()
        {
            return this.HapinessPoints;
        }
    }
}
