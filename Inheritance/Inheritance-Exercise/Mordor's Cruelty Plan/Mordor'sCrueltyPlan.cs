namespace MordorsCrueltyPlan
{
    using Mordor_s_Cruelty_Plan.Factories;
    using Mordor_s_Cruelty_Plan.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MordorsCrueltyPlanMain
    {
        public static void Main()
        {
            //instance of food factory;
            var foodFactory = new FoodFactory();
            //instance of mood factory;
            var moodFactory = new MoodFactory();
            //instance of gandalf;
            var gandalf = new Gandalf();

            //reda the input line;
            var inputFood = Console.ReadLine()
                .Split(new[] { ' ' , '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var foodStr in inputFood)
            {
                var food = foodFactory.GetFood(foodStr);

                gandalf.Eat(food);
            }

            //var for total point of all foods;
            var totalhapinessPoint =  gandalf.GetHapinessPoint();
            //var for mood acording to total points;
            var currentMood = moodFactory.GetMood(totalhapinessPoint);

            //print the result;
            Console.WriteLine(totalhapinessPoint);

            Console.WriteLine(currentMood);
        }
    }
}   

    