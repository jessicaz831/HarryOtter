/* Jessica Zhu
 * Jan 20, 2020
 * Inherits Unit class, stores Dehentor's information, Dehentor is one of the bosses 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HarryOtterBattle
{
    class Dehentor : Unit
    {
        // Dehentor inherits from Unit so it calls the Unit constructor as a base
        public Dehentor(BattlePlayer owner, int spawnX, int spawnY)
            : base("Dehentor", owner, spawnX, spawnY)
        {
            // Set spawn and characterBox size
            characterBox = new Rectangle(spawnX + 105, spawnY + 70, 159, 194);

            // Set max health
            maxHealth = 150;
            currentHealth = 150;

            // Set name
            name = "DeHENtor";
            // Set image
            image = Properties.Resources.Dehentor;
        }

        /// <summary>
        /// Overrides the abstract method from the Unit class, generates a random number for attack for a Dehentor type unit
        /// </summary>
        /// <returns>Returns the attack damage</returns>
        public override int GenerateAttack()
        {
            // generate a random number between 30 and 50 for attack
            int attackDamage = rng.Next(30, 51);

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
