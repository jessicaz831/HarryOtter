/* Emily Chang
 * January 20, 2020
 * Child class of Recipes, creates WaterYouDoing objects
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryOtterBattle
{
    class WaterYouDoing : Recipes
    {
        /// <summary>
        /// WaterYouDoing constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ingredients"></param>
        public WaterYouDoing(string name, List<Ingredients> ingredients)
            : base()
        {
            // save if there was an error loading the file
            error = Load("WaterYouDoing.txt", ingredients);
            // save the name of the spell
            this.name = name;
        }
    }
}
