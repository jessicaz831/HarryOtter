/* Emily Chang
 * January 20, 2020
 * Child class of Recipes, creates ComboSpell objects, loads ComboSpell files
 */
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class ComboSpell : Recipes
    {
        /// <summary>
        /// ComboSpell constructor
        /// </summary>
        /// <param name="name">the name of the recipe</param>
        /// <param name="ingredients">all ingredients available</param>
        public ComboSpell(string name, List<Ingredients> ingredients)
            : base()
        {
            // store if there was an error loading the file
            error = Load("", ingredients);
            
            // store the name of the recipe
            this.name = name;
        }

        /// <summary>
        /// load multiple files for ComboSpell
        /// </summary>
        /// <param name="fileName">name of the file (blank for the ComboSpell)</param>
        /// <param name="ingredients">all available ingredients</param>
        /// <returns>returns if there was an error loading the file or not</returns>
        public override bool Load(string fileName, List<Ingredients> ingredients)
        {
            // a counter to see which index the ingredient is at
            int count = 0;

            // stores each line of the file 
            int temp;
            try
            {
                // reads the ClaimToFlame file
                using (StreamReader file = new StreamReader("ClaimToFlame.txt"))
                {
                    // only repeats when there is still text to read
                    while (file.Peek() != -1)
                    {
                        // stores one line of the file into the temp variable
                        int.TryParse(file.ReadLine(), out temp);

                        // if there is a quantity for that ingredient, store it in the spellIngredients list
                        if (temp != 0)
                        {
                            spellIngredients.Add(ingredients[count].GetElement);
                        }

                        // increase the counter by 1
                        count++;
                    }

                    // set the counter equal to zero
                    count = 0;
                }
                // reads the LeafMeAlone file
                using (StreamReader file = new StreamReader("LeafMeAlone.txt"))
                {
                    // only repeats when there is still text to read
                    while (file.Peek() != -1)
                    {
                        // stores one line of the file into the temp variable
                        int.TryParse(file.ReadLine(), out temp);

                        // if there is a quantity for that ingredient, store it in the spellIngredients list
                        if (temp != 0)
                        {
                            spellIngredients.Add(ingredients[count].GetElement);
                        }

                        // increase the counter by 1
                        count++;
                    }

                    // set the counter equal to zero
                    count = 0;
                }

                // return that there was no error
                return error = false;
            }
            catch (Exception e)
            {
                // return that there was an error
                return error = true;
            }
        }
    }
}
