namespace Mordor_s_Cruelty_Plan.Models.Moods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Angry : Mood
    {
        private const string MoodName = "Angry";

        public Angry()
            :base(MoodName)
        {
        }
    }
}
