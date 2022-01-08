/* Jessica Zhu
 * Jan 20, 2020
 * Inherits Unit class, stores Harry's information, Harry specializes in attacking and healing
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HarryOtterBattle
{
    class Harry : Unit
    {
        // Harry inherits from Unit so it calls the Unit constructor as a base
        public Harry(BattlePlayer owner, int spawnX, int spawnY)
            : base("Harry", owner, spawnX, spawnY)
        {
            // Set spawn and characterBox size
            characterBox = new Rectangle(spawnX, spawnY, 136, 220);

            // Set max health
            maxHealth = 400;
            currentHealth = 400;

            // Set name
            name = "Harry OTTER";

            // Set image
            image = Properties.Resources.HarryOtter;
        }

        /// <summary>
        /// Harry specializes in attacking so his attacks deal 1.5x the normal damage
        /// </summary>
        /// <returns>Returns damage amount</returns>
        public override int GenerateAttack()
        {
            // multiply damage by 1.5
            spellDamage = spellDamage * 1.5;
            // return damage as an int
            return (int)spellDamage;
        }

        /// <summary>
        /// Overrides the virtual method from the Unit class because Harry specializes in healing and therefore heals different than default, generates a random number for heal for a Harry type unit
        /// </summary>
        /// <returns></returns>
        public override int GenerateHeal()
        {
            // generate a random number between 75 and 175 for healing
            int heal = rng.Next(75, 176);

            // return the random number
            return heal;
        }
    }
}
