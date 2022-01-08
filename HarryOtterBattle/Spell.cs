/* Emily Chang
 * January 20, 2020
 * Create the spell based on the recipe that was found based on the ingredients that the user inputs, output the spell that the user creates
 */
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class Spell
    {
        // store the spell and its stats
        private string name;
        private int spellPower;

        // store if there was an error outputting the file
        private bool error = false;

        // stroes if the spell failed or not
        private bool fail;

        /// <summary>
        /// spell constructor
        /// </summary>
        /// <param name="spellRecipe">recipe for the spell being created</param>
        /// <param name="available">specific ingredients the user is using</param>
        public Spell(Recipes spellRecipe, List<Ingredients> available)
        {
            // make the spell based off of the recipe (the recipe name wil become the spell name) 
            if (spellRecipe != null)
            {
                // stores the name of the spell
                name = spellRecipe.GetName;

                // calculate the power of the spell
                spellPower = SpellPower(available);

                // stores that the spell did not fail
                fail = false;

            }
            // if the spellRecipe is null that means that no spell could be created so the "name" of the spell will be "Spell Failed" and the power will be 0
            else
            {
                this.name = "Spell Failed";
                this.spellPower = 0;
                // set fail equal to true
                fail = true;
            }
        }

        /// <summary>
        /// calculate the power of the spell
        /// </summary>
        /// <param name="available">the ingredients the user is using to create the spell</param>
        /// <returns>returns the power of the spell</returns>
        public int SpellPower(List<Ingredients> available)
        {
            // set the power equal to zero
            int power = 0;

            // make the counter equal to the number of ingredients in the recipe
            int counter = available.Count;

            // cycle through all of the ingredients in the spell and calculate the ingredient power
            for (int i = 0; i < available.Count; i++)
            {
                // add the calculated ingredient power to the power of the other ingredients
                power = power + IngredientPower(available[i]);
                // multiplier to make the spells more powerful
                power = power * 5;
            }

            // find an average of the ingredient power to get the power of the spell
            return power / counter;
            
        }

        /// <summary>
        /// calculate the power of a specific ingredient
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns>returns the power of the ingredient</returns>
        public int IngredientPower(Ingredients ingredient)
        {
            // average the quality and the freshness of the ingredient to get the power
            return (ingredient.GetQuality + ingredient.GetFreshness) / 2;
        }

        /// <summary>
        /// output the spell the user creates
        /// </summary>
        /// <param name="combo">if the player is making a combo spell or not</param>
        /// <returns>returns if there was an error</returns>
        public bool SpellOutput(bool combo)
        {
            // runs when the player is creating a combo spell and the spell they are currently creating did not fail
            if (combo == true && fail == false)
            {
                // stores the power of the first spell the player made
                int tempPower = 0;
                try
                {
                    // reads the file for the spell that the player already created
                    using (StreamReader file = new StreamReader("Spell.txt"))
                    {
                        // keeps reading untill there is nothing else in the file to read
                        while (file.Peek() != -1)
                        {
                            // runs when the file reads a number
                            if (int.TryParse(file.ReadLine(), out tempPower) == true)
                            {
                                // adds the power of the first spell and the second spell together to create the power of the combo spell
                                spellPower = tempPower + spellPower;
                            }
                        }
                    }
                    // overwrite the Spell.txt file with the combo spell information
                    using (StreamWriter file = new StreamWriter("Spell.txt"))
                    {
                        //write the name and the power on separate lines of the file
                        file.WriteLine("Combo Spell");
                        file.WriteLine(spellPower);
                    }

                    // return that there weren't any errors
                    return error = false;

                }
                catch (Exception e)
                {
                    // return that there was an error
                    return error = true;
                }

            }
            // runs when the player is creating their first spell
            else
            {
                try
                {
                    // overwrite the Spell.txt file
                    using (StreamWriter file = new StreamWriter("Spell.txt"))
                    {
                        //write the name and the power on separate lines of the file
                        file.WriteLine(name);
                        file.WriteLine(spellPower);
                    }

                    // return that there was no error
                    return error = false;
                }
                catch (Exception e)
                {
                    // return that there was an error in outputting the spell
                    return error = true;
                }
            }
            
        }

        // returns the spell name and can also set a new spell name
        public string GetSpell
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // returns the spell power
        public int GetPower
        {
            get
            {
                return spellPower;
            }
        }

        // returns if there was an error
        public bool GetError
        {
            get
            {
                return error;
            }
        }
    }
}
