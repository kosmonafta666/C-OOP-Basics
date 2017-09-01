namespace Mordor_s_Cruelty_Plan.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Mood
    {
        public string MoodName
        {
            get; set;
        }

        public Mood(string moodName)
        {
            this.MoodName = moodName;
        }

        public override string ToString()
        {
            return this.MoodName;
        }
    } 
}
