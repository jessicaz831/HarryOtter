/* Jessica Zhu
 * Jan 20, 2020
 * Stores a battle's information, what state the battle is in, moves projectiles, creates units, loads files
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace HarryOtterBattle
{
    class Battle
    {
        // create two players for the battle, one which is the user and one which is the computer
        protected BattlePlayer p1 = new BattlePlayer("Player 1", 80, 200);
        protected BattlePlayer p2 = new BattlePlayer("Player 2", 500, 150);

        // create rectangle object for the background
        protected Rectangle backgroundBox = new Rectangle(0, 0, 900, 700);

        // create a random number generator to generate a random enemy
        Random enemyGen = new Random();

        // store state of battle
        protected int state;
        public const int BATTLING_STATE = 0;
        public const int WIN_STATE = 1;
        public const int LOSE_STATE = 2;

        /// <summary>
        /// Create new battle
        /// </summary>
        public Battle()
        {
        }

        /// <summary>
        /// Create Harry unit for p1
        /// </summary>
        public void CreateHarry()
        {
            p1.CreateHarry();
        }

        /// <summary>
        /// Create Ron unit for p1
        /// </summary>
        public void CreateRon()
        {
            p1.CreateRon();
        }

        /// <summary>
        /// Create Haremione unit for p1
        /// </summary>
        public void CreateHaremione()
        {
            p1.CreateHaremione();
        }

        /// <summary>
        /// Create Voldemoth unit for p2, used for loading
        /// </summary>
        public void CreateVoldemoth()
        {
            p2.CreateVoldemoth();
        }

        /// <summary>
        /// Create Dolores unit for p2, used for loading
        /// </summary>
        public void CreateDolores()
        {
            p2.CreateDolores();
        }

        /// <summary>
        /// Create Dehentor unit for p2, used for loading
        /// </summary>
        public void CreateDehentor()
        {
            p2.CreateDehentor();
        }

        /// <summary>
        /// Selects a random enemy (Dehentor, Dolores, or Voldemoth) for the player to fight
        /// </summary>
        public void SelectRandomEnemy()
        {
            // generate a random number between 1 and 3 to choose an enemy
            int num = enemyGen.Next(1, 4);

            // Create the unit for p2 according to the random number
            if (num == 1)
            {
                CreateDehentor();
            }
            else if (num == 2)
            {
                CreateDolores();
            }
            else if (num == 3)
            {
                CreateVoldemoth();
            }
        }

        /// <summary>
        /// Create projectiles for both players' units
        /// </summary>
        public void BothCreateProjectiles()
        {
            // load the spell that the player will fire according to spellMakingForm
            p1.GetSelectedUnit.LoadSpell();
            // create projectile for user's unit
            p1.GetSelectedUnit.CreateProjectile();
            // create projectile for computer's unit
            p2.GetSelectedUnit.CreateProjectile();
        }

        /// <summary>
        /// Sets firingProjectile to true for both players so they cannot spam
        /// </summary>
        public void BothFiringProjectiles()
        {
            // set firingProjectile to true so user cannot spam
            p1.GetSelectedUnit.FiringProjectile = true;
            // set firingProjectile to true so computer cannot spam
            p2.GetSelectedUnit.FiringProjectile = true;
        }

        /// <summary>
        /// Heals the player's unit while enemy unit attacks
        /// </summary>
        public void Heal()
        {
            // heal user's unit
            p1.GetSelectedUnit.Heal();

            // create projectile for computer's unit
            p2.GetSelectedUnit.CreateProjectile();
            // set firingProjectile to true so computer cannot spam
            p2.GetSelectedUnit.FiringProjectile = true;
        }

        /// <summary>
        /// Check if p1's unit has max health, return if it's true or not
        /// </summary>
        public bool P1UnitHasMaxHealth
        {
            get
            {
                return p1.GetSelectedUnit.UnitHasMaxHealth;
            }
        }

        /// <summary>
        /// Get p1 so it can be used elsewhere
        /// </summary>
        public BattlePlayer GetP1
        {
            get
            {
                return p1;
            }
        }

        /// <summary>
        /// Get p2 so it can be used elsewhere
        /// </summary>
        public BattlePlayer GetP2
        {
            get
            {
                return p2;
            }
        }

        /// <summary>
        /// Checks what state the battle is in and sets a state accordingly
        /// </summary>
        /// <param name="player">check player's units</param>
        /// <param name="enemy">check opposing player's units</param>
        public void EndBattle(BattlePlayer player, BattlePlayer enemy)
        {
            // if all of user's units are dead
            if (player.CheckDeadUnits() == true)
            {
                // they lose
                state = LOSE_STATE;
            }
            // if all of enemy's units are dead
            else if (enemy.CheckDeadUnits() == true)
            {
                // user wins
                state = WIN_STATE;
            }
            else
            {
                // the battle continues
                state = BATTLING_STATE;
            }
        }

        /// <summary>
        /// Checks if user has won
        /// </summary>
        public bool HasUserWon
        {
            get
            {
                // returns true if the battle state is WIN_STATE
                return state == WIN_STATE;
            }
        }

        /// <summary>
        /// Checks if user has lost
        /// </summary>
        public bool HasUserLost
        {
            get
            {
                // returns true if the battle state is LOSE_STATE
                return state == LOSE_STATE;
            }
        }

        /// <summary>
        ///  Checks if user is still battling
        /// </summary>
        public bool IsUserBattling
        {
            get
            {
                // returns true if the battle state is BATTLING_STATE
                return state == BATTLING_STATE;
            }
        }

        /// <summary>
        /// Moves projectiles
        /// </summary>
        /// <param name="player">The unit's owner that is attacking</param>
        /// <param name="enemy">The unit's owner that is being attacked</param>
        public void Attack(BattlePlayer player, BattlePlayer enemy)
        {
            // user's projectile moves towards computer's unit
            player.GetSelectedUnit.Attack(enemy.GetSelectedUnit);
            // computer's projectile moves towards user's unit
            enemy.GetSelectedUnit.Attack(player.GetSelectedUnit);
        }

        /// <summary>
        /// Checks if player is currently attacking
        /// </summary>
        /// <param name="player">The player to be checked</param>
        /// <returns>Returns true if they are attacking, false if they aren't</returns>
        public bool IsPlayerAttacking(BattlePlayer player)
        {
            if (player.GetSelectedUnit.FiringProjectile == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Formats labels for units, displays the unit's name, and current health out of max health
        /// </summary>
        /// <param name="player">The player that is having its units checked</param>
        /// <returns>Returns a string in the format "Name \r\n HP: currentHealth/maxHealth"</returns>
        public string LabelFormat(BattlePlayer player)
        {
            return player.GetSelectedUnit.GetName + "\r\nHP: " + player.GetSelectedUnit.GetCurrentHealth + "/" + player.GetSelectedUnit.GetMaxHealth;
        }

        /// <summary>
        /// Loads Battle.txt file so user can continue where they last saved
        /// </summary>
        public void Load()
        {
            using (StreamReader file = new StreamReader("Battle.txt"))
            {
                // first line is p1's xSpawn
                p1.SetXSpawn = int.Parse(file.ReadLine());
                // second line is p1's ySpawn
                p1.SetYSpawn = int.Parse(file.ReadLine());
                // third line is how many units p1 has
                int numberOfAllyUnits = int.Parse(file.ReadLine());

                // loop for as many units that p1 has
                for (int i = 0; i < numberOfAllyUnits; i++)
                {
                    // next line is the unitType of units[i]
                    string type = file.ReadLine();

                    // if the type saved is Harry
                    if (type == "Harry")
                    {
                        // create Harry for p1
                        CreateHarry();
                    }
                    // if the type saved is Ron
                    else if (type == "Ron")
                    {
                        // create Ron for p1
                        CreateRon();
                    }
                    // if the type saved is Haremione
                    else if (type == "Haremione")
                    {
                        // create Haremione for p1
                        CreateHaremione();
                    }

                    // next line is the currentHealth of unit at i when last saved, set it to the unit at i
                    p1.GetUnit(i).GetCurrentHealth = int.Parse(file.ReadLine());
                }

                // after setting up all of p1's units, the next line is p2's xSpawn
                p2.SetXSpawn = int.Parse(file.ReadLine());
                // next line is p2's ySpawn
                p2.SetYSpawn = int.Parse(file.ReadLine());
                // next line is how many units p2 has
                int numberOfEnemyUnits = int.Parse(file.ReadLine());

                // loop for as many units that p2 has
                for (int i = 0; i < numberOfEnemyUnits; i++)
                {
                    // next line is the unitType of units[i]
                    string type = file.ReadLine();

                    // if the type saved is Voldemoth
                    if (type == "Voldemoth")
                    {
                        // create Voldemoth for p2
                        CreateVoldemoth();
                    }
                    // if the type saved is Dolores
                    else if (type == "Dolores")
                    {
                        // create Dolores for p2
                        CreateDolores();
                    }
                    // if the type saved is Dehentor
                    else if (type == "Dehentor")
                    {
                        // create Dehentor for p2
                        CreateDehentor();
                    }

                    // next line is the currentHealth of unit at i when last saved, set it to the unit at i
                    p2.GetUnit(i).GetCurrentHealth = int.Parse(file.ReadLine());
                }
            }
        }

        /// <summary>
        /// Draws custom graphics for background
        /// </summary>
        /// <param name="e">Lets us access the 'Graphics' to draw images</param>
        public void Draw(PaintEventArgs e)
        {
            // draws background
            e.Graphics.DrawImage(Properties.Resources.Forest, backgroundBox);

            // draw both player's units
            p1.Draw(e);
            p2.Draw(e);
        }
    }
}
