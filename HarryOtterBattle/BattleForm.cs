/* Jessica Zhu
 * Jan 20, 2020
 * Create a 1v1 battle where the player can attack or heal to defeat a random boss, load and save files, using inheritance and polymorphism
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HarryOtterBattle
{
    public partial class BattleForm : Form
    {
        // create a battle object
        private Battle battle = new Battle();

        // create an array that stores quantities of ingredients
        private int[] quantity = new int[12];

        public BattleForm()
        {
            InitializeComponent();

            // hide unnecessary buttons, labels and pic boxes
            btnAttack.Hide();
            btnHeal.Hide();
            btnContinueBattle.Hide();
            btnContinueShop.Hide();
            lblHowToPlay.Hide();
            lblInfo.Hide();
            lblAllyHealth.Hide();
            lblEnemyHealth.Hide();
            picWin.Hide();
            picLose.Hide();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // hide start screen
            btnPlay.Hide();
            btnLoad.Hide();
            picLogo.Hide();

            // show label that says "Choose your character"
            lblHowToPlay.Show();

            // show pic boxes for character select
            picHarry.Show();
            picRon.Show();
            picHaremione.Show();
        }

        private void picHarry_Click(object sender, EventArgs e)
        {
            // hide character select screen
            picHarry.Hide();
            picRon.Hide();
            picHaremione.Hide();

            // move and change label to "How To Play"
            lblHowToPlay.Location = new Point(289, 9);
            lblHowToPlay.Text = "How To Play";

            // instructions on how to buy ingredients from the shop
            lblInfo.Show();
            lblInfo.Text = "Click on the element you would like to buy.\r\nTo buy ingredients click on the ingredient name.\r\nQuality, freshness, and cost increase from left to \r\nright.\r\nHint: Spells require 2 different elements to be \r\ncreated.";

            // show continue button
            btnContinueShop.Show();

            // create Haremione unit for user
            battle.CreateHarry();
            // create random unit for computer
            battle.SelectRandomEnemy();
        }

        private void picRon_Click(object sender, EventArgs e)
        {
            // hide character select screen
            picHarry.Hide();
            picRon.Hide();
            picHaremione.Hide();

            // move and change label to "How To Play"
            lblHowToPlay.Location = new Point(289, 9);
            lblHowToPlay.Text = "How To Play";

            // show instructions on how to buy ingredients from the shop
            lblInfo.Show();
            lblInfo.Text = "Click on the element you would like to buy.\r\nTo buy ingredients click on the ingredient name.\r\nQuality, freshness, and cost increase from left to \r\nright.\r\nHint: Spells require 2 different elements to be \r\ncreated.";

            // show continue button
            btnContinueShop.Show();

            // create Haremione unit for user
            battle.CreateRon();
            // create random unit for computer
            battle.SelectRandomEnemy();
        }

        private void picHaremione_Click(object sender, EventArgs e)
        {
            // hide character select screen
            picHarry.Hide();
            picRon.Hide();
            picHaremione.Hide();

            // move and change label to "How To Play"
            lblHowToPlay.Location = new Point(289, 9);
            lblHowToPlay.Text = "How To Play";

            // show instructions on how to buy ingredients from the shop
            lblInfo.Show();
            lblInfo.Text = "Click on the element you would like to buy.\r\nTo buy ingredients click on the ingredient name.\r\nQuality, freshness, and cost increase from left to \r\nright.\r\nHint: Spells require 2 different elements to be \r\ncreated.";

            // show continue button
            btnContinueShop.Show();

            // create Haremione unit for user
            battle.CreateHaremione();
            // create random unit for computer
            battle.SelectRandomEnemy();
        }

        private void btnContinueShop_Click(object sender, EventArgs e)
        {
            // create new ShopForm and open it
            ShopForm shopForm = new ShopForm();
            shopForm.ShowDialog();

            // switch continue buttons
            btnContinueBattle.Show();
            btnContinueShop.Hide();

            // show instructions on how to battle and make spells
            lblInfo.Text = "You can attack the enemy or heal yourself.\r\nHarry specializes in attacking and healing.\r\nRon specializes in only healing.\r\nHaremione specializes in only attacking.\r\n\r\nWhen you attack, you must make a spell.\r\nFollow a recipe in your recipe book.\r\nTo make a combo spell, you must combine the spells\r\nClaim To FLAME and LEAF Me Alone.";
        }

        private void btnContinueBattle_Click(object sender, EventArgs e)
        {
            // hide instruction screen
            btnContinueBattle.Hide();
            lblHowToPlay.Hide();
            lblInfo.Hide();

            // enable timer
            tmrLoop.Enabled = true;

            // show attack, heal, and save button, and health points
            lblAllyHealth.Show();
            lblEnemyHealth.Show();
            btnAttack.Show();
            btnHeal.Show();
            btnSave.Show();

            // refresh graphics
            Refresh();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            // disable timer so nothing moves
            tmrLoop.Enabled = false;

            // if user has no ingredients they immediately lose
            if (CheckNoIngredients() == true)
            {
                // display a message box
                MessageBox.Show("Out of ingredients, cannot attack anymore");

                // disable timer
                tmrLoop.Enabled = false;

                // show lose screen
                btnRestart.Show();
                btnQuit.Show();
                picLose.Show();

                // hide battle screen
                lblAllyHealth.Hide();
                lblEnemyHealth.Hide();
                btnAttack.Hide();
                btnHeal.Hide();
                btnSave.Hide();

                // exit subprogram
                return;
            }

            // disable buttons
            btnAttack.Enabled = false;
            btnHeal.Enabled = false;

            // create the spellMakingForm object
            SpellMakingForm spellMakingForm = new SpellMakingForm();
            // show spell making form so user can create spell
            spellMakingForm.ShowDialog();

            // create and fire projectiles when user clicks attack
            battle.BothCreateProjectiles();
            battle.BothFiringProjectiles();

            // enable timer
            tmrLoop.Enabled = true;
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            // only run if user's unit is not already at max health
            if (!battle.P1UnitHasMaxHealth)
            {
                // enable timer
                tmrLoop.Enabled = true;

                // disable button so user cannot spam 
                btnAttack.Enabled = false;
                btnHeal.Enabled = false;

                // heal unit when user clicks heal
                battle.Heal();
            }
        }

        /// <summary>
        /// Checks if user has 0 ingredients or not
        /// </summary>
        /// <returns>Returns true if they have 0 ingredients, returns false if not</returns>
        public bool CheckNoIngredients()
        {
            // declare sum variable
            int sum = 0;

            try
            {
                using (StreamReader file = new StreamReader("Bought.txt"))
                {
                    while (file.Peek() != -1)
                    {
                        // save quantities into quantity array
                        for (int i = 0; i < quantity.Length; i++)
                        {
                            int.TryParse(file.ReadLine(), out quantity[i]);
                        }
                    }
                }
            }
            catch
            {
                // display message box
                MessageBox.Show("Error reading file");
            }

            // add all quantities together
            for (int i = 0; i < quantity.Length; i++)
            {
                sum = sum + quantity[i];
            }

            // if sum is 0 return true
            if (sum == 0)
            {
                return true;
            }
            // if sum is > 0 return false
            else
            {
                return false;
            }
        }

        private void tmrLoop_Tick(object sender, EventArgs e)
        {
            // move projectiles for user and computer
            battle.Attack(battle.GetP1, battle.GetP2);
            // update hp labels
            UpdateLabels();
            // check if user won or lost
            CheckWin();
            // refresh graphics
            Refresh();

            // if user and computer are both not attacking, enable attack and heal button and disable timer
            if (!battle.IsPlayerAttacking(battle.GetP1) && !battle.IsPlayerAttacking(battle.GetP2))
            {
                // if the user has won or lost disable timer and exit so buttons don't show on end screens
                if (battle.HasUserWon || battle.HasUserLost)
                {
                    tmrLoop.Enabled = false;
                    return;
                }

                btnAttack.Enabled = true;
                btnHeal.Enabled = true;
                tmrLoop.Enabled = false;
            }
        }

        /// <summary>
        /// Draws all custom graphics
        /// </summary>
        /// <param name="e">Lets us access the 'Graphics' to draw images</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // only draw if timer is enabled
            if (tmrLoop.Enabled == true)
            {
                // draw battle background
                battle.Draw(e);
            }
        }

        /// <summary>
        /// Updates HP labels showing the unit's name and current health out of max health
        /// </summary>
        public void UpdateLabels()
        {
            lblAllyHealth.Text = battle.LabelFormat(battle.GetP1);
            lblEnemyHealth.Text = battle.LabelFormat(battle.GetP2);
        }

        /// <summary>
        /// Checks if player has won or lost
        /// </summary>
        public void CheckWin()
        {
            // check if player's units are all dead
            battle.EndBattle(battle.GetP1, battle.GetP2);

            // if user won
            if (battle.HasUserWon)
            {
                // disable timer
                tmrLoop.Enabled = false;
                // show win screen
                btnRestart.Show();
                btnQuit.Show();
                picWin.Show();
                // hide battle screen
                lblAllyHealth.Hide();
                lblEnemyHealth.Hide();
                btnAttack.Hide();
                btnHeal.Hide();
                btnSave.Hide();
            }
            // if user lost
            else if (battle.HasUserLost)
            {
                // disable timer
                tmrLoop.Enabled = false;
                // show lose screen
                btnRestart.Show();
                btnQuit.Show();
                picLose.Show();
                // hide battle screen
                lblAllyHealth.Hide();
                lblEnemyHealth.Hide();
                btnAttack.Hide();
                btnHeal.Hide();
                btnSave.Hide();
            }
            // if user is still battling
            else if (battle.IsUserBattling)
            {
                // exit subprogram
                return;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // when user clicks restart button, the entire application will restart
            Application.Restart();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // when user clicks the quit button, the entire application will close
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // write both players' save info into a text file
                using (StreamWriter file = new StreamWriter("Battle.txt"))
                {
                    file.Write(battle.GetP1.SavePlayersInfo());
                    file.Write(battle.GetP2.SavePlayersInfo());
                }
            }
            catch
            {
                // if there is an error, show message box saying progress couldn't be saved
                MessageBox.Show("Could not save progress! Try again later.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // only run if file exists
            if (File.Exists("Battle.txt"))
            {
                try
                {
                    using (StreamReader file = new StreamReader("Battle.txt"))
                    {
                        if (file.Peek() == -1)
                        {
                            // if the file is empty, show message box saying there is no save files
                            MessageBox.Show("You don't have any save files.");
                            
                            // exit subprogram
                            return;
                        }

                        // load previously saved info
                        battle.Load();
                    }
                }
                catch
                {
                    // if there is an error, show message box saying there was an error
                    MessageBox.Show("Error loading save file.");
                }
            }
            else
            {
                // if the file didn't exist, show message box saying there is no save files
                MessageBox.Show("You don't have any save files.");
                return;
            }

            // hide start screen
            btnPlay.Hide();
            btnLoad.Hide();
            picLogo.Hide();

            // show attack and heal button, and health points
            lblAllyHealth.Show();
            lblEnemyHealth.Show();
            btnAttack.Show();
            btnHeal.Show();
            btnSave.Show();

            // enable timer
            tmrLoop.Enabled = true;
        }
    }
}
