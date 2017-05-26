using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var cheeseCals = 500;
            var tomatoSauceCals = 150;
            var SalamiCals = 600;
            var PepperCals = 50;

            var totalCalories = 0;

            for (int i = 0; i < number; i++)
            {
                var ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    totalCalories += cheeseCals; 
                }
                else if (ingredient == "tomato sauce")
                {
                    totalCalories += tomatoSauceCals;
                }
                else if (ingredient == "salami")
                {
                    totalCalories += SalamiCals;
                }
                else if (ingredient == "pepper")
                {
                    totalCalories += PepperCals;
                }
            }
            Console.WriteLine("Total calories: {0}", totalCalories);


        }
    }
}
