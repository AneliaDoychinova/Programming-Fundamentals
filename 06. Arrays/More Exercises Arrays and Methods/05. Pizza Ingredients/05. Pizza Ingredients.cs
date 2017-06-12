using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().Split().ToArray();
            var minLenght = int.Parse(Console.ReadLine());

            var countIngredients = 0;
            var usedIngredients = new List<string>();

            for (int i = 0; i < ingredients.Length; i++)
            { 
                if (countIngredients == 10)
                {
                    break;
                }

                if (ingredients[i].Length == minLenght)
                {
                    usedIngredients.Add(ingredients[i]);
                    Console.WriteLine("Adding {0}.", ingredients[i]);
                    countIngredients++;
                }
               
            }
            Console.WriteLine("Made pizza with total of {0} ingredients.", countIngredients);
            Console.WriteLine("The ingredients are: {0}.", string.Join(", ", usedIngredients));
        }
    }
}
