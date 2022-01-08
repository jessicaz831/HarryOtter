/* Emily Chang
 * January 20, 2020
 * Child class of Recipes, creates LeafMeAlone objects
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class LeafMeAlone : Recipes
    {
        /// <summary>
        /// LeafMeAlone constructor
        /// </summary>
        /// <param name="name">name of the recipe</param>
        /// <param name="ingredients">all of the ingredients available</param>
        public LeafMeAlone(string name, List<Ingredients> ingredients)
            : base()
        {
            // save if there was an error loading the file
            error = Load("LeafMeAlone.txt", ingredients);
            // save the name of the recipe
            this.name = name;
        }
    }
}
