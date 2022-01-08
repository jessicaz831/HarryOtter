/* Jessica Zhu
 * Jan 20, 2020
 * Inherits Unit class, stores Haremione's information, Haremione specializes in attacking
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HarryOtterBattle
{
    class Haremione : Unit
    {
        // Haremione inherits from Unit so it calls the Unit constructor as a base
        public Haremione(BattlePlayer owner, int spawnX, int spawnY)
            : base("Haremione", owner, spawnX, spawnY)
        {
            // Set spawn and characterBox size
            characterBox = new Rectangle(spawnX + 10, spawnY, 193, 218); // 232,262

            // Set max health
            maxHealth = 400;
            currentHealth = 400;

            // Set name
            name = "HAREmione Granger";

            // Set image
            image = Properties.Resources.HaremioneGranger;
        }

        /// <summary>
        /// Haremiones specializes in attacking so her attacks deal 1.75x the normal damage
        /// </summary>
        /// <returns>Returns damage amount</returns>
        public override int GenerateAttack()
        {
            // multiply damage by 1.75
            spellDamage = spellDamage * 1.75;
            // return damage as an int
            return (int)spellDamage;
        }
    }
}
