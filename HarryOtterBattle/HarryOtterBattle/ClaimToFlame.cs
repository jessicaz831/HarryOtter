/* Emily Chang
 * January 20, 2020
 * Child class of Recipes, creates ClameToFlame objects
 */
using System.IO;
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class ClaimToFlame : Recipes
    {
        /// <summary>
        /// ClaimToFlame constructor
        /// </summary>
        /// <param name="name">name of the recipe</param>
        /// <param name="ingredients">all available ingredients</param>
        public ClaimToFlame(string name, List<Ingredients> ingredients)
            : base()
        {
            // save if there was an error loading the file
            error = Load("ClaimToFlame.txt", ingredients);
            // save the name of the recipe
            this.name = name;
        }

    }
}

