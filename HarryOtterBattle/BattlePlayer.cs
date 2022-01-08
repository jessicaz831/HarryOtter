/* Jessica Zhu
 * Jan 20, 2020
 * Stores a player's information, allows them to create units, save info
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace HarryOtterBattle
{
    class BattlePlayer
    {
        // create a list of units for the player, for now players only have one unit
        protected List<Unit> units = new List<Unit>();

        // store name of unit
        protected string name;
        // store where unit spawns
        protected int xUnitSpawn, yUnitSpawn;
        // store selected index
        protected int selectedIndex;

        /// <summary>
        /// Create a new player
        /// </summary>
        /// <param name="name">player name</param>
        /// <param name="xSpawn">xspawn location</param>
        /// <param name="ySpawn">yspawn location</param>
        public BattlePlayer(string name, int xSpawn, int ySpawn)
        {
            this.name = name;
            xUnitSpawn = xSpawn;
            yUnitSpawn = ySpawn;
        }

        /// <summary>
        /// get unit at given index
        /// </summary>
        /// <param name="i">index of unit</param>
        /// <returns>Returns unit at given index if within units list, if not return null</returns>
        public Unit GetUnit(int i)
        {
            if (i >= 0 && i < units.Count)
            {
                return units[i];
            }

            return null;
        }

        /// <summary>
        /// Create Harry unit for player and add to their list
        /// </summary>
        public void CreateHarry()
        {
            units.Add(new Harry(this, xUnitSpawn, yUnitSpawn));
        }

        /// <summary>
        /// Create Ron unit for player and add to their list
        /// </summary>
        public void CreateRon()
        {
            units.Add(new Ron(this, xUnitSpawn, yUnitSpawn));
        }

        /// <summary>
        /// Create Haremione unit for player and add to their list
        /// </summary>
        public void CreateHaremione()
        {
            units.Add(new Haremione(this, xUnitSpawn, yUnitSpawn));
        }

        /// <summary>
        /// Create Voldemoth unit for player and add to their list
        /// </summary>
        public void CreateVoldemoth()
        {
            units.Add(new Voldemoth(this, xUnitSpawn, yUnitSpawn));
        }

        /// <summary>
        /// Create Dolores unit for player and add to their list
        /// </summary>
        public void CreateDolores()
        {
            units.Add(new Dolores(this, xUnitSpawn, yUnitSpawn));
        }

        /// <summary>
        /// Create Dehentor unit for player and add to their list
        /// </summary>
        public void CreateDehentor()
        {
            units.Add(new Dehentor(this, xUnitSpawn, yUnitSpawn));
        }

        /// <summary>
        /// Saves player's info into one string
        /// </summary>
        /// <returns>Returns string with all required info</returns>
        public string SavePlayersInfo()
        {
            // store xSpawn, ySpawn, and number of units in a string
            string temp = xUnitSpawn + "\r\n" + yUnitSpawn + "\r\n" + units.Count + "\r\n";

            // for each unit, add the string created by SaveUnitsInfo in the unit class to this string
            for (int i = 0; i < units.Count; i++)
            {
                temp = temp + units[i].SaveUnitsInfo();
            }

            // return the string
            return temp;
        }

        /// <summary>
        /// Set the player's xSpawn value
        /// </summary>
        public int SetXSpawn
        {
            set
            {
                xUnitSpawn = value;
            }
        }

        /// <summary>
        /// Set the player's ySpawn value
        /// </summary>
        public int SetYSpawn
        {
            set
            {
                yUnitSpawn = value;
            }
        }

        /// <summary>
        /// Get the number of units that the player owns
        /// </summary>
        public int GetNumberOfUnits
        {
            get
            {
                return units.Count;
            }
        }

        /// <summary>
        /// Get the currently selected unit by the player
        /// </summary>
        public Unit GetSelectedUnit
        {
            get
            {
                return units[selectedIndex];
            }
        }

        /// <summary>
        /// Choose the next unit
        /// </summary>
        public void SelectNextUnit()
        {
            // if index is at the last unit go back to the beginning of the list
            if (selectedIndex == units.Count - 1)
            {
                selectedIndex = 0;
            }
            // increment the index to go through the list
            else
            {
                selectedIndex++;
            }
        }

        /// <summary>
        /// Checks if all units are dead
        /// </summary>
        /// <returns>Returns true if all dead, false if there is still units alive</returns>
        public bool CheckDeadUnits()
        {
            // create a counter to count how many units are dead
            int deadUnits = 0;
            
            // check all units that player owns
            for (int i = 0; i < units.Count; i++)
            {
                // if the unit's hp is 0 or below, it's dead
                if (units[i].CheckDead() == true)
                {
                    // increment counter 
                    deadUnits++;
                }
            }

            // if amount of counted dead units is equal to the amount of units that the player has return true
            if (deadUnits == units.Count)
            {

                return true;
            }
            return false;
        }

        /// <summary>
        /// Draws custom graphics for a player's units
        /// </summary>
        /// <param name="e">Lets us access the 'Graphics' to draw images</param>
        public void Draw(PaintEventArgs e)
        {
            // loop through all the units to draw them
            for (int i = 0; i < units.Count; i++)
            {
                units[i].Draw(e);
            }
        }

    }
}
