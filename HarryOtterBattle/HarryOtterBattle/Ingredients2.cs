/*
 * Rachel Tu
 * January 20, 2020
 * the ingredients for the shop, ingredients for the player to buy
 * in order to create potions/spells
 */
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class Ingredients2
    {
        //The name of three ingredients from each different element
        //ELEMENT_FIRE = "Draco Malfire, Heatmione Granger, Volde-warm";
        //ELEMENT_WATER = "Slyther-river, Galleon-of-water, Hogswave";
        //ELEMENT_EARTH = "Earth-eaters, Muckle, Dirt-lord";
        //ELEMENT_AIR = "Huffle puff, Womping Wiff-low, Wiz-air";
        //Show ingredient stats
        protected int ingredientQuality, ingredientCost, ingredientFreshness, maxIngredientAmount;
        protected int decreaseQuality, decreaseFreshness, decreaseCost;

        protected string name;

        /// <summary>
        /// Get the quality of the ingredient
        /// </summary>
        public int IngredientQuality
        {
            get
            {
                return ingredientQuality;
            }
        }
        /// <summary>
        /// Get the cost of the ingredient
        /// </summary>
        public int IngredientCost
        {
            get
            {
                return ingredientCost;
            }
        }
        /// <summary>
        /// Get the freshness of the ingredient
        /// </summary>
        public int IngredientFreshness
        {
            get
            {
                return ingredientFreshness;
            }
        }
        public int MaxIngredientAmount
        {
            get
            {
                return maxIngredientAmount;
            }
        }
        public int DecreaseQuality
        {
            get
            {
                return decreaseQuality;
            }
        }
        public int DecreaseFreshness
        {
            get
            {
                return decreaseFreshness;
            }
        }
        public int DecreaseCost
        {
            get
            {
                return decreaseCost;
            }
        }


        public void Load(string fileName)
        {
            using (StreamReader file = new StreamReader(fileName))
            {
                while (file.Peek() != -1)
                {
                    name = file.ReadLine();
                    int.TryParse(file.ReadLine(), out ingredientQuality);
                    int.TryParse(file.ReadLine(), out ingredientFreshness);
                    int.TryParse(file.ReadLine(), out ingredientCost);
                    file.ReadLine();
                }
            }
        }
        /// <summary>
        /// Ingredient stats for each fire ingredient
        /// </summary>
        /// <param name="ingredientQuality"></param>
        /// <param name="ingredientFreshness"></param>
        /// <param name="ingredientCost"></param>
        public void FireIngredientStats(int ingredientQuality, int ingredientFreshness, int ingredientCost)
        {
            ingredientQuality = 7;
            ingredientFreshness = 5;
            ingredientCost = 14;
        }
        /// <summary>
        /// Ingredient stats for each earth ingredient
        /// </summary>
        /// <param name="ingredientQuality"></param>
        /// <param name="ingredientFreshness"></param>
        /// <param name="ingredientCost"></param>
        public void EarthIngredientStats(int ingredientQuality, int ingredientFreshness, int ingredientCost)
        {
            ingredientQuality = 5;
            ingredientFreshness = 4;
            ingredientCost = 8;
        }
        /// <summary>
        /// Ingredient stats for each water ingredient
        /// </summary>
        /// <param name="ingredientQuality"></param>
        /// <param name="ingredientFreshness"></param>
        /// <param name="ingredientCost"></param>
        public void WaterIngredientStats(int ingredientQuality, int ingredientFreshness, int ingredientCost)
        {
            ingredientQuality = 6;
            ingredientFreshness = 7;
            ingredientCost = 7;
        }
        /// <summary>
        /// Ingredient stats for each air ingredient
        /// </summary>
        /// <param name="ingredientQuality"></param>
        /// <param name="ingredientFreshness"></param>
        /// <param name="ingredientCost"></param>
        public void AirIngredientStats(int ingredientQuality, int ingredientFreshness, int ingredientCost)
        {
            ingredientQuality = 6;
            ingredientFreshness = 7;
            ingredientCost = 10;
        }

        ///////////////////////////////
        public string GetName
        {
            get
            {
                return name;
            }
        }
    }
}
