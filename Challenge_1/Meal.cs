using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Meal
    {
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public string Ingredients { get; internal set; }
        public string Description { get; internal set; }
        public decimal ItemPrice { get; set; }

        public Meal(string mealName, int mealNumber, string ingredients, string description, decimal itemPrice)
        {
            MealName = mealName;
            MealNumber = mealNumber;
            Ingredients = ingredients;
            Description = description;
            ItemPrice = ItemPrice;
        }

        public Meal()
        {
        }

    }
}
