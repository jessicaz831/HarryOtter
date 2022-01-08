/* Jessica Zhu
 * Jan 20, 2020
 * Inherits Unit class, stores Voldemoth's information, Voldemoth is one of the bosses 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HarryOtterBattle
{
    class Voldemoth : Unit
    {
        // Voldemoth inherits from Unit so it calls the Unit constructor as a base
        public Voldemoth(BattlePlayer owner, int spawnX, int spawnY)
            : base("Voldemoth", owner, spawnX, spawnY)
        {
            // Set spawn and characterBox size
            characterBox = new Rectangle(spawnX, spawnY, 412, 276);

            // Set max health
            maxHealth = 500;
            currentHealth = 500;

            // Set name
            name = "VoldeMOTH";

            // Set image
            image = Properties.Resources.Voldemoth;
        }

        /// <summary>
        /// Overrides the abstract method from the Unit class, generates a random number for attack for a Voldemoth type unit
        /// </summary>
        /// <returns>Returns the attack damage</returns>
        public override int GenerateAttack()
        {
            // generate a random number between 100 and 150 for attack
            int attackDamage = rng.Next(100, 151);

            // return the random number
            return attackDamage;
        }

        /// <summary>
        /// Overrides the virtual method from the Unit class, creates projectile on left side of characterBox instead of right
        /// </summary>
        public override void CreateProjectile()
        {
            // if user is already attacking, exit subprogram to prevent spam
            if (firingProjectile == true)
            {
                return;
            }

            // create projectile on left side of unit rectangle
            projectileBox = new Rectangle(characterBox.X, characterBox.Y + (characterBox.Y / 2), 30, 30);
        }

        /// <summary>
        /// Overrides the virtual method from the Unit class, moves projectile to the left and slower instead of right
        /// </summary>
        public override void MoveProjectile()
        {
            // move projectile to the left but slower by 5 to give the user's attack priority
            projectileBox.X = projectileBox.X - (int)PROJECTILE_SPEED + 5;
            // update location
            projectileBox.Location = new Point(projectileBox.X, projectileBox.Y);
        }
    }
}
