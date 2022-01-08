/* Jessica Zhu
 * Jan 20, 2020
 * Stores a unit's information, creates unit, allows unit to attack and heal
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
    abstract class Unit
    {
        // store current and max health of unit
        protected int maxHealth, currentHealth;
        // stores unit type and name of unit
        protected string unitType, name;

        // stores what type of spell and how much damage it deals from spell files
        protected string spellType;
        protected double spellDamage;

        // random number generator
        protected Random rng = new Random();

        // store if unit is currently attacking or healing to prevent spamming
        protected bool firingProjectile = false;
        protected  bool healing = false;

        // store speed of projectile
        protected const float PROJECTILE_SPEED = 20;

        // store player that owns the unit
        protected BattlePlayer master;

        // create rectangles for custom graphics
        protected Rectangle characterBox;
        protected Rectangle projectileBox;
        // store image that will be displayed in rectangles
        protected Image image;

        // store unit types
        public const string UNIT_HARRY = "Harry";
        public const string UNIT_RON = "Ron";
        public const string UNIT_HAREMIONE = "Haremione";
        public const string UNIT_VOLDEMOTH = "Voldemoth";

        /// <summary>
        /// Create a unit object of the given type
        /// </summary>
        /// <param name="type">uses one of the constants to create unit of said type</param>
        /// <param name="owner">player who owns the unit</param>
        /// <param name="spawnX">where unit is spawned on x axis</param>
        /// <param name="spawnY">where unit is spawned on y axis</param>
        public Unit(string type, BattlePlayer owner, int spawnX, int spawnY)
        {
            // set unit type
            unitType = type;
            // set owner of unit
            master = owner;
        }

        /// <summary>
        /// Saves unit's info into one string
        /// </summary>
        /// <returns></returns>
        public string SaveUnitsInfo()
        {
            // store unit type and current health of the unit in one string
            string temp = unitType + "\r\n" + currentHealth + "\r\n";
            // return the string
            return temp;
        }

        /// <summary>
        /// Get player that owns unit
        /// </summary>
        public BattlePlayer Master
        {
            get
            {
                return master;
            }
        }

        /// <summary>
        /// Get unit's current health
        /// </summary>
        public int GetCurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                currentHealth = value;
            }
        }

        /// <summary>
        /// Get unit's max health
        /// </summary>
        public int GetMaxHealth
        {
            get
            {
                return maxHealth;
            }
        }

        /// <summary>
        /// Get unit's name
        /// </summary>
        public string GetName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Get or set the unit type
        /// </summary>
        public string GetUnitType
        {
            get
            {
                return unitType;
            }
            set
            {
                unitType = value;
            }
        }

        /// <summary>
        /// Get or set if unit is currently attacking or not
        /// </summary>
        public bool FiringProjectile
        {
            get
            {
                return firingProjectile;
            }
            set
            {
                firingProjectile = value;
            }
        }

        /// <summary>
        /// Get or set if unit is currently healing or not
        /// </summary>
        public bool Healing
        {
            get
            {
                return healing;
            }
            set
            {
                healing = value;
            }
        }

        /// <summary>
        /// Checks if unit has max health already, returns true if they do
        /// </summary>
        public bool UnitHasMaxHealth
        {
            get
            {
                return currentHealth == maxHealth;
            }
        }

        /// <summary>
        /// draws custom graphics for units and projectiles
        /// </summary>
        /// <param name="e">Lets us access the 'Graphics' to draw images</param>
        public void Draw(PaintEventArgs e)
        {
            // draw unit's image
            e.Graphics.DrawImage(image, characterBox);

            // draws a different projectile image depending on what spell they make from spellMakingForm
            if (spellType == "Claim To FLAME")
            {
                e.Graphics.DrawImage(Properties.Resources.FireSpell, projectileBox);
            }
            else if (spellType == "LEAF Me Alone")
            {
                e.Graphics.DrawImage(Properties.Resources.LeafSpell, projectileBox);
            }
            else if (spellType == "Get Out Of AtmospHERE")
            {
                e.Graphics.DrawImage(Properties.Resources.WindSpell, projectileBox);
            }
            else if (spellType == "WATER You Doing")
            {
                e.Graphics.DrawImage(Properties.Resources.WaterSpell, projectileBox);
            }
            else if (spellType == "Combo Spell")
            {
                e.Graphics.DrawImage(Properties.Resources.ComboSpell, projectileBox);
            }

            // if unit is type Dehentor, Dolores, or Voldemoth
            if (this is Dehentor || this is Dolores || this is Voldemoth)
            {
                // draw an enemy spell projectile
                e.Graphics.DrawImage(Properties.Resources.EnemySpell, projectileBox);
            }
            
        }

        /// <summary>
        /// Loads the spell type and it's damage from the output of spellMakingForm
        /// </summary>
        public void LoadSpell()
        {
            try
            {
                using (StreamReader file = new StreamReader("Spell.txt"))
                {
                    // saves first line to spellType variable
                    spellType = file.ReadLine();
                    // saves second line to spellDamage variable
                    double.TryParse(file.ReadLine(), out spellDamage);
                }
            }
            catch
            {
                // show message box
                MessageBox.Show("Error loading spell file");
            }
        }

        /// <summary>
        /// Creates the projectile
        /// </summary>
        public virtual void CreateProjectile()
        {
            // if user is already attacking, exit subprogram to prevent spam
            if (firingProjectile == true)
            {
                return;
            }

            // if the spell is a combo spell, make the projectileBox bigger
            if (spellType == "Combo Spell")
            {
                // create projectile on right side of unit rectangle but bigger for combo spell
                projectileBox = new Rectangle(characterBox.X + characterBox.Width, characterBox.Y + (characterBox.Y / 2), 55, 55);
            }
            else
            {
                // create projectile on right side of unit rectangle
                projectileBox = new Rectangle(characterBox.X + characterBox.Width, characterBox.Y + (characterBox.Y / 2), 40, 40);
            }
        }

        /// <summary>
        /// Move the projectile across the screen 
        /// </summary>
        /// <param name="enemy">unit that the projectile is being fired at from the attacker's perspective</param>
        public void Attack(Unit enemy)
        {
            // move the projectile
            MoveProjectile();

            // projectile touches the enemy unit's box
            if (projectileBox.IntersectsWith(enemy.characterBox))
            {
                // save returned value from GenerateAttack to attackDamage variable
                int attackDamage = GenerateAttack();

                // if enemy unit's current health minus the random number is less than or equal to 0
                if (enemy.currentHealth - attackDamage <= 0)
                {
                    // set enemy unit's current health to 0
                    enemy.currentHealth = 0;
                }
                else
                {
                    // subtract random number from enemy unit's current health
                    enemy.currentHealth = enemy.currentHealth - attackDamage;
                }

                // set firing projectile to false, unit is not attacking anymore
                firingProjectile = false;

                // move projectile box off screen
                projectileBox.Location = new Point(-1000, -1000);
            }
        }

        /// <summary>
        /// Move projectile to the right, enemy's projectiles move to the left so they'll be done in their child classes
        /// </summary>
        public virtual void MoveProjectile()
        {
            // move projectile to the right
            projectileBox.X = projectileBox.X + (int)PROJECTILE_SPEED;
            // update location
            projectileBox.Location = new Point(projectileBox.X, projectileBox.Y);
        }

        /// <summary>
        /// For enemy, generate a random number for an attack depending on the unit type, every unit type has a different range for attacks so they'll be done in their child classes
        /// For user, load attack from spellMakingForm file and multiply depending on the unit type, every unit type has a different multiplier so they'll be done in their child classes
        /// </summary>
        /// <returns>Returns the generated number</returns>
        public abstract int GenerateAttack();
        

        /// <summary>
        /// Generate a random number between 50 and 150 to heal, heal ranges change depending on the unit type, only "ally" units can heal which is why it is virtual and not abstract
        /// </summary>
        /// <returns>Returns the randomly generated number</returns>
        public virtual int GenerateHeal()
        {
            // generate a random number between 50 and 150 and save it in the heal variable
            int heal = rng.Next(50, 151);
            // return the heal number
            return heal;
        }

        /// <summary>
        /// Heal the unit
        /// </summary>
        public void Heal()
        {
            // if user is already healing, exit subprogram to prevent spamming
            if (healing == true)
            {
                return;
            }

            // generate a random number between 50 and 200 for heal
            int heal = GenerateHeal();

            // if unit is already at max health exit subprogram
            if (currentHealth == maxHealth)
            {
                return;

            }
            // if unit's current health plus random number is greater than or equal to max health
            else if (currentHealth + heal >= maxHealth)
            {
                // unit's current health is equal to their max health
                currentHealth = maxHealth;
            }
            else
            {
                // add random number to unit's current health
                currentHealth = currentHealth + heal;
            }
        }

        /// <summary>
        /// Checks if the unit is dead
        /// </summary>
        /// <returns>returns true if unit's current health is less than or equal to 0, returns false if not</returns>
        public bool CheckDead()
        {
            if (currentHealth <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
