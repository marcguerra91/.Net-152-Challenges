using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MealUI
    {
        MealRepository _mealRepository = new MealRepository();
        List<Meal> mealItems;
        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            mealItems = _mealRepository.GetContentList();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an action:" +
                    "\n1. Create new meal" +
                    "\n2. View current meal list" +
                    "\n3. Remove from current meals" +
                    "\n4. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: // Create new meal
                        CreateContent();
                        break;
                    case 2: // View meal list
                        PrivateMealList();
                        break;
                    case 3: // Remove a current meal
                       RemoveMeal();
                        break;
                    case 4: //Exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("That won't work! Try 1-4!");
                        Console.ReadLine();
                        break;
                }
            }
        }
        private void CreateContent()
        {
            Meal newContent = new Meal();
            Console.WriteLine("\nPlease assign a number for the meal you would like to add:");
            newContent.MealNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\nWhat's the name of the meal you would like to add?");
            newContent.MealName = Console.ReadLine();
            Console.WriteLine("\n What are the ingredients for the meal you would like to add?");
            newContent.Ingredients = Console.ReadLine();
            Console.WriteLine("\n Please give a description of the meal");
            newContent.Description = Console.ReadLine();
            Console.WriteLine("\n How much would you like to charge for the meal?");
            newContent.ItemPrice = decimal.Parse(Console.ReadLine());
            Console.Clear();

            _mealRepository.AddContentToList(newContent);
        }
        private void PrivateMealList()
        {
            Console.Clear();
            List<Meal> mealList = _mealRepository.GetContentList();
            foreach(Meal content in mealList)
            {
                Console.WriteLine($"Current meal information: \n#{content.MealNumber}\n {content.MealName}\n {content.Ingredients}\n {content.Description}\n ${content.ItemPrice}\n");
            }
        }
        private void RemoveMeal()
        {
            Console.Clear();
            Console.WriteLine("Enter the number of the meal you would like to remove:");
            foreach (Meal content in _mealRepository.GetContentList())
            {
                Console.WriteLine();
            }
            int removeMealItem = int.Parse(Console.ReadLine());
            foreach (Meal meal in _mealRepository.GetContentList())
            {
                if (removeMealItem == meal.MealNumber)
                {
                    _mealRepository.RemoveMealByNumber(meal);
                    break;
                }
            }
        }
       
    }
}
