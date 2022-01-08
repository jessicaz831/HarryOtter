/* Emily Chang
 * January 20, 2020
 * Create the list of recipes for the recipe book, loads the files for the Recipes
 */
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class Recipes
    {
        // store the name of the spell
        protected string name;

        // store if there was an error loading the files
        protected bool error;

        // store the list of ingredients required to create the spell
        protected List<string> spellIngredients = new List<string>();

        /// <summary>
        /// loads all of the files, except for the combo spell. 
        /// </summary>
        /// <param name="fileName">name of the file</param>
        /// <param name="ingredients">all of the available ingredients</param>
        /// <returns>returns if there was an error loading in the file or not</returns>
        public virtual bool Load(string fileName, List<Ingredients> ingredients)
        {
            // a counter to see which index the ingredient is at
            int count = 0;

            // stores each line of the file 
            int temp;
            try
            {
                // reads the file
                using (StreamReader file = new StreamReader(fileName))
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
                // returns that there was no error
                return error = false; 
            }
            catch (Exception e)
            {
                // returns that there was an error
                return error = true;
            }
        }

        // returns a specific spell ingredient based on the index it's at
        public string GetOneSpellIngredient(int i)
        {
            return spellIngredients[i];
        }

        // returns the whole spellIngredients list
        public List<string> GetSpellIngredients
        {
            get
            {
                return spellIngredients;
            }
        }

        // returns the name of the spell
        public string GetName
        {
            get
            {
                return name;
            }
        }

        // returns if there was an error loading the file
        public bool GetError
        {
            get
            {
                return error;
            }
        }
    }
}
