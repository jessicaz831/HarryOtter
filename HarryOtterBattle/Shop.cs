/*
 * Rachel Tu
 * January 20, 2020
 * A shop for the player to buy ingredients
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    abstract class Shop
    {
        protected List<Ingredients2> ingredient = new List<Ingredients2>();
        protected string ingredients, getIngredient, sellIngredient;
        protected int ingredientStatsRoll;
        protected int shopIngredients;
        protected int maxIngredient;
        protected int maxInventoryIngredient;
        protected int statsDecrease;
        protected int count;
        protected int player;
        protected string quality, freshness, cost;


        public string Quality
        {
            get
            {
                return quality;
            }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    quality = value;
                }
            }
        }
        public string Freshness
        {
            get
            {
                return freshness;
            }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    freshness = value;
                }
            }
        }
        public string Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    cost = value;
                }
            }
        }
        public string Ingredients
        {
            get
            {
                return ingredients;
            }
        }
        /// <summary>
        /// Get ingredients from the shop
        /// </summary>
        public string GetIngredients
        {
            get
            {
                return getIngredient;
            }
        }

        /// <summary>
        /// To get a random stat generator
        /// </summary>
        public int IngredientStatsRoll
        {
            get
            {
                return ingredientStatsRoll;
            }
        }
        /// <summary>
        /// To get the shop ingredients
        /// </summary>
        public int ShopIngredients
        {
            get
            {
                return shopIngredients;
            }
        }
        /// <summary>
        /// To get the max ingredient
        /// </summary>
        public int MaxIngredient
        {
            get
            {
                return maxIngredient;
            }
        }
        /// <summary>
        /// To get the max inventory amount to store ingredients
        /// </summary>
        public int MaxInventoryIngredient
        {
            get
            {
                return maxInventoryIngredient;
            }
        }
        /// <summary>
        /// To decrease the ingredient stats
        /// </summary>
        public int StatsDecrease
        {
            get
            {
                return statsDecrease;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        /// <summary>
        /// Create the shop
        /// </summary>
        /// <param name="getIngredients"></param>
        /// <param name="sellIngredients"></param>
        /// <param name="restockIngredient"></param>
        public Shop(string getIngredients, string sellIngredients, string restockIngredients)
        {
            this.ingredients = Ingredients;
            this.ingredientStatsRoll = IngredientStatsRoll;
            this.getIngredient = GetIngredients;
            this.shopIngredients = ShopIngredients;
            this.maxIngredient = MaxIngredient;
            this.maxInventoryIngredient = MaxInventoryIngredient;
            this.statsDecrease = StatsDecrease;
            this.count = Count;
        }
        /// <summary>
        /// Check if the player reaches the max amount of ingredients that they can
        /// store in their inventory
        /// </summary>
        /// <param name="inventory"></param>
        public void GetMaxInventoryIngredient(int inventory)
        {
            maxInventoryIngredient = 3;
            if (inventory == 3)
            {
                return;
            }
        }
        /// <summary>
        /// To restock the ingredients
        /// </summary>
        /// <param name="maxIngredient"></param>
        public void RestockShopIngredients(int maxIngredient)
        {
            if (ShopIngredients <= maxIngredient)
            {
                return;
            }
        }
        public void IngredientStatDecrease()
        {
            count = count - 1;
        }
        public void GetIngredient()
        {

        }
    }
}
