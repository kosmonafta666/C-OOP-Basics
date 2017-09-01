namespace Mordor_s_Cruelty_Plan.Factories
{
    using Mordor_s_Cruelty_Plan.Models;
    using Mordor_s_Cruelty_Plan.Models.Moods;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MoodFactory
    {
        public Mood GetMood(int hapinessPoints)
        {
            if (hapinessPoints < -5)
            {
                return new Angry();
            }

            if (hapinessPoints <= 0)
            {
                return new Sad();
            }

            if (hapinessPoints <= 15)
            {
                return new Happy();
            }

            return new JavaScript();
        }
    }
}
