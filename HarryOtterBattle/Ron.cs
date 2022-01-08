/* Jessica Zhu
 * Jan 20, 2020
 * Inherits Unit class, stores Ron's information, Ron specializes in healing
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HarryOtterBattle
{
    class Ron : Unit
    {
        // Ron inherits from Unit so it calls the Unit constructor as a base
        public Ron(BattlePlayer owner, int spawnX, int spawnY)
            : base("Ron", owner, spawnX, spawnY)
        {
            // Set spawn and characterBox size
            characterBox = new Rectangle(spawnX + 15, spawnY, 96, 216);

            // Set max health
            maxHealth = 400;
            currentHealth = 400;

            // Set name
            name = "Ron WEASEL";

            // Set image
            image = Properties.Resources.RonWeasel;
        }

        /// <summary>
        /// Ron does not specialize in attacking so his attacks deal the normal amount
        /// </summary>
        /// <returns>Returns damage amount</returns>
        public override int GenerateAttack()
        {
            // return damage as an int
            return (int)spellDamage;
        }

        /// <summary>
        /// Overrides the virtual method from the Unit class because Ron specializes in healing and therefore heals different than default, generates a random number for heal for a Ron type unit
        /// </summary>
        /// <returns></returns>
        public override int GenerateHeal()
        {
            // generate a random number between 100 and 200 for healing
            int heal = rng.Next(100, 201);

            // return the random number
            return heal;
        }
    }
}
