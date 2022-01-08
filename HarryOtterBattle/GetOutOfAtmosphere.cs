/* Emily Chang
 * January 20, 2020
 * Child class of Recipes, creates GetOutOfAtmosphere objects
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class GetOutOfAtmosphere : Recipes
    {
        /// <summary>
        /// GetOutOfAtmosphere constructor
        /// </summary>
        /// <param name="name">name of the recipe</param>
        /// <param name="ingredients">all ingredients available</param>
        public GetOutOfAtmosphere(string name, List<Ingredients> ingredients)
            : base()
        {
            // save if there was an error loading the file
            error = Load("GetOutOfAtmosphere.txt", ingredients);
            // save the name of the spell
            this.name = name;
        }
    }
}
