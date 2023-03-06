using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Smoothie
    {
        private string[] ingredients;

        public Smoothie(string[] ingredients)
        {
            this.ingredients = ingredients;
        }

        public string[] Ingredients
        {
            get { return ingredients; }
        }

        public string GetCost()
        {
            double cost = 0;
            Dictionary<string, double> prices = new Dictionary<string, double>() {
                {"Strawberries", 1.5},
                {"Banana", 0.5},
                {"Mango", 2.5},
                {"Blueberries", 1.0},
                {"Raspberries", 1.0},
                {"Apple", 1.75},
                {"Pineapple", 3.5}
            };
            foreach (string ingredient in ingredients)
            {
                cost += prices[ingredient];
            }
            return "£" + cost.ToString("F2");
        }

        public string GetPrice()
        {
            double cost = double.Parse(GetCost().Substring(1));
            double price = cost * 2.5;
            return "£" + price.ToString("F2");
        }

        public string GetName()
        {
            List<string> sortedIngredients = ingredients.ToList();
            sortedIngredients.Sort();
            for (int i = 0; i < sortedIngredients.Count; i++)
            {
                if (sortedIngredients[i].EndsWith("berries"))
                {
                    sortedIngredients[i] = sortedIngredients[i].Replace("berries", "berry");
                }
            }
            string name = string.Join(" ", sortedIngredients);
            if (sortedIngredients.Count > 1)
            {
                name += " Fusion";
            }
            else
            {
                name += " Smoothie";
            }
            return name;
        }
    }
}