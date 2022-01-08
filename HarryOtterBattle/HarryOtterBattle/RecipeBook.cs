/* Emily Chang
 * January 20, 2020
 * Has a list of all possible recipes. Check if the spell the player wants to create is a real spell.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class RecipeBook
    {
        // stores all of the possible recipes
        private List<Recipes> recipes = new List<Recipes>();

        // all of the possible recipes
        private Recipes claimToFlame;
        private Recipes leafMeAlone;
        private Recipes waterYouDoing;
        private Recipes getOutOfAtmosphere;
        private Recipes comboSpell;

        // stores the ingredients of the spell that wasn't made for combo spells
        private List<string> spellNotMade = new List<string>();

        // stores if it is possible to create a combo spell with what ingredients were chosen
        private bool combo = false;

        // stores if the file was able to be inputted or not
        private bool error = false;

        /// <summary>
        /// creates the RecipeBook object
        /// </summary>
        /// <param name="ingredients">list of all possible ingredients</param>
        public RecipeBook (List<Ingredients> ingredients)
        {
            // load all of the recipe files
            LoadRecipes(ingredients);
            // add the lists of ingredients into Recipes objects
            AddRecipes();
        }

        /// <summary>
        /// creates all of the Recipes objects
        /// </summary>
        /// <param name="ingredients">all available ingredients</param>
        private void LoadRecipes(List<Ingredients> ingredients)
        {
            claimToFlame = new ClaimToFlame("Claim To FLAME", ingredients);
            leafMeAlone = new LeafMeAlone("LEAF Me Alone", ingredients);
            waterYouDoing = new WaterYouDoing("WATER You Doing", ingredients);
            getOutOfAtmosphere = new GetOutOfAtmosphere("Get Out Of AtmospHERE", ingredients);
            comboSpell = new ComboSpell("Combo Spell", ingredients);
        }

        // adds the Recipes objects to the recipes list
        public void AddRecipes()
        {          
            recipes.Add(claimToFlame);
            recipes.Add(leafMeAlone);
            recipes.Add(waterYouDoing);
            recipes.Add(getOutOfAtmosphere);
            recipes.Add(comboSpell);

            // checks if there were any errors
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].GetError == true)
                {
                    error = true;
                }
            }
        }

        /// <summary>
        /// check if a recipe exists with the ingredients that the player has chosen
        /// </summary>
        /// <param name="recipes">list of all available recipes</param>
        /// <param name="available">list of ingredients the player chose</param>
        /// <returns></returns>
        public Recipes CheckSpell(List<Recipes> recipes, List<Ingredients> available)
        {
            // stores the ingredients that are being consumed when creating a spell
            List<string> consumed = new List<string>();

            // stores the first ingredient element
            string tempElement = "";

            // runs if the player is trying to create a combo spell
            if (combo == true)
            {
                // cycle through all of the available ingredients
                for (int j = 0; j < available.Count; j++)
                {
                    // if the recipe contains the available element, add that element to the consumed list
                    if (spellNotMade.Contains(available[j].GetElement) && tempElement != available[j].GetElement)
                    {
                        consumed.Add(available[j].GetElement);
                        tempElement = available[j].GetElement;
                    }
                    // if the consumed list is identical to the spellNotMade list, find the corresponding recipe and return it
                    if (consumed.All(spellNotMade.Contains) && consumed.Count == spellNotMade.Count)
                    {
                        for (int i = 0; i < recipes.Count; i++)
                        {
                            if (recipes[i].GetSpellIngredients.All(spellNotMade.Contains) && recipes[i].GetSpellIngredients.Count == spellNotMade.Count)
                            {
                                return recipes[i];
                            }
                        }
                    }
                    // if the recipe does not contain one of the player's chosen ingredients, remove all of the ingredients from the consumed list
                    // this is becuase the player can no longer make that spell
                    else if (!spellNotMade.Contains(available[j].GetElement))
                    {
                        for (int h = consumed.Count - 1; h >= 0; h--)
                        {
                            consumed.Remove(consumed[h]);
                            tempElement = "";
                        }
                    }
                }
            }
            else
            {
                // create temporary lists to store the recipes for each individual recipe in the combo spell
                List<string> temp1 = new List<string>();
                List<string> temp2 = new List<string>();

                // save half of the ingredients into the temp1 and the other half into temp2
                for (int i = 0; i < comboSpell.GetSpellIngredients.Count / 2; i++)
                {
                    temp1.Add(comboSpell.GetSpellIngredients[i]);
                }
                for (int j = comboSpell.GetSpellIngredients.Count - 1; j >= comboSpell.GetSpellIngredients.Count / 2; j--)
                {
                    temp2.Add(comboSpell.GetSpellIngredients[j]);
                }
                // cycle through all of the recipes except comboSpell
                for (int i = 0; i < recipes.Count - 1; i++)
                {
                    // cycle through all of the available ingredients
                    for (int j = 0; j < available.Count; j++)
                    {
                        // if the recipe contains the available element, add that element to the consumed list
                        if (recipes[i].GetSpellIngredients.Contains(available[j].GetElement) && tempElement != available[j].GetElement)
                        {
                            consumed.Add(available[j].GetElement);
                            tempElement = available[j].GetElement;
                        }
                        // if the consumed list is identical to the spellIngredients list for that particular recipe, return that recipe
                        if (consumed.All(recipes[i].GetSpellIngredients.Contains) && consumed.Count == recipes[i].GetSpellIngredients.Count)
                        {
                            // if the spell is one of the spells needed for the combo spell, set combo equal to true and save the other ingredients needed to create a combo spell into the spellNotMade list
                            if (recipes[i].GetSpellIngredients.All(temp1.Contains) && recipes[i].GetSpellIngredients.Count == temp1.Count)
                            {
                                for (int k = 0; k < temp2.Count; k++)
                                {
                                    spellNotMade.Add(temp2[k]);
                                }
                                combo = true;
                            }                   
                            else if (recipes[i].GetSpellIngredients.All(temp2.Contains) && recipes[i].GetSpellIngredients.Count == temp2.Count)
                            {
                                for (int k = 0; k < temp1.Count; k++)
                                {
                                    spellNotMade.Add(temp1[k]);
                                }
                                combo = true;
                            }
                            // return the recipe that the user used to create
                            return recipes[i];
                        }
                        // if the recipe does not contain one of the player's chosen ingredients, remove all of the ingredients from the consumed list
                        // this is becuase the player can no longer make that spell
                        else if (!recipes[i].GetSpellIngredients.Contains(available[j].GetElement))
                        {
                            for (int h = consumed.Count - 1; h >= 0; h--)
                            {
                                consumed.Remove(consumed[h]);
                                tempElement = "";
                            }
                        }
                    }
                }
            }
            
            // return null if the player is unable to create a spell with their chosen ingredients
            // with combo spells, even the first spell will fail if the second spel created was not the right one
            return null;
        }

        // returns all of the recipes
        public List<Recipes> GetRecipes
        {
            get
            {
                return recipes; 
            }
        }

        // returns if an error occured when reading the files
        public bool GetError
        {
            get
            {
                return error;
            }
        }

        // returns the combo variable or sets a new value for combo
        public bool GetCombo
        {
            get
            {
                return combo;
            }
            set
            {
                combo = value;
            }
        }
    }
}
