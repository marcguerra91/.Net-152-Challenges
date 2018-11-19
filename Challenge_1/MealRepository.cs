using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MealRepository
    {
        List<Meal> _listOfMeals = new List<Meal>();

        public void AddContentToList(Meal content)
        {
            _listOfMeals.Add(content);
        }
        public void RemoveMealByNumber(Meal mealNumber)
        {
            _listOfMeals.Remove(mealNumber);
        }

        public List<Meal> GetContentList()
        {
            return _listOfMeals;
        }
    }
}
