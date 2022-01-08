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
    public partial class ShopForm : Form
    {
        private Ingredients2 fire, earth, air, water;
        Random dice = new Random();
        private int ingredientStatsRoll;

        private List<Ingredients2> ingredientsList = new List<Ingredients2>();
        Ingredients2 draco = new Draco_Malfire("Draco.txt");
        Ingredients2 heatmione = new Heatmione_Granger("Heatmione.txt");
        Ingredients2 voldewarm = new Voldewarm("Voldewarm.txt");
        Ingredients2 hogswave = new Hogswave("Hogswave.txt");
        Ingredients2 slyter = new Slyter_River("Slyter.txt");
        Ingredients2 galleon = new Galleon_of_Water("Galleon.txt");
        Ingredients2 whomping = new Whomping_Wifflow("Whomping.txt");
        Ingredients2 wizair = new Wiz_air("Wizair.txt");
        Ingredients2 huffle = new Hufflepuff("Huffle.txt");
        Ingredients2 eartheaters = new Earth_Eaters("Earth.txt");
        Ingredients2 dirt = new Dirt_lord("Dirt.txt");
        Ingredients2 muckle = new Muckle("Muckle.txt");

        private int[] bought = new int[12];

        private int money = 150;

        public ShopForm()
        {
            InitializeComponent();
            pnlFire.Hide();
            pnlEarth.Hide();
            pnlAir.Hide();
            pnlWater.Hide();
            btnBack.Hide();

            lblMoney.Text = "$" + money;

            //fire = new Ingredients("Draco.txt");
            //earth = new Ingredients(5, 4, 8);
            //air = new Ingredients(6, 7, 10);
            //water = new Ingredients(6, 7, 7);
        }

        private void CreateIngredients()
        {
            ingredientsList.Add(draco);
        }
        /// <summary>
        /// To show the ingredients stats for the fire element and hide buttons that are no longer needed.
        /// Show the "back" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFire_Click(object sender, EventArgs e)
        {
            pnlFire.Show();
            btnAir.Hide();
            btnEarth.Hide();
            btnWater.Hide();
            btnBack.Show();
            pnlEarth.Hide();
            pnlAir.Hide();
            pnlWater.Hide();

        }
        public int IngredientStatsRoll
        {
            get
            {
                return ingredientStatsRoll;
            }
        }
        /// <summary>
        /// Show the ingredient stats for the Earth element and hide the buttons that are not needed.
        /// Show the "back" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEarth_Click(object sender, EventArgs e)
        {
            btnAir.Hide();
            btnFire.Hide();
            btnWater.Hide();
            pnlAir.Hide();
            btnBack.Show();
            pnlFire.Hide();
            pnlEarth.Show();
            pnlWater.Hide();

        }
        /// <summary>
        /// Show all buttons for the user to click when they click the "back" button.
        /// After the "back" button is clicked, hide the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            btnFire.Show();
            btnAir.Show();
            btnEarth.Show();
            btnWater.Show();
            pnlFire.Show();
            pnlEarth.Show();
            pnlAir.Show();
            pnlWater.Show();
            btnBack.Hide();
        }

        private void btnDracoMalfire_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = draco.IngredientQuality + " units";
            lblFreshness.Text = draco.IngredientFreshness + " units";
            lblCost.Text = "$" + draco.IngredientCost;

            if (money - draco.IngredientCost >= 0)
            {
                money = money - draco.IngredientCost;
                UpdateMoney();

                bought[0] = bought[0] + 1;
                btnDracoMalfire.Text = "Draco - " + bought[0];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void tmrStatDecrease_Tick(object sender, EventArgs e)
        {

        }

        private void btnHeatmione_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = heatmione.IngredientQuality + " units";
            lblFreshness.Text = heatmione.IngredientFreshness + " units";
            lblCost.Text = "$" + heatmione.IngredientCost;

            if (money - heatmione.IngredientCost >= 0)
            {
                money = money - heatmione.IngredientCost;
                UpdateMoney();

                bought[1] = bought[1] + 1;
                btnHeatmione.Text = "Heatmione - " + bought[1];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void btnVoldewarm_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = voldewarm.IngredientQuality + " units";
            lblFreshness.Text = voldewarm.IngredientFreshness + " units";
            lblCost.Text = "$" + voldewarm.IngredientCost;

            if (money - voldewarm.IngredientCost >= 0)
            {
                money = money - voldewarm.IngredientCost;
                UpdateMoney();

                bought[2] = bought[2] + 1;
                btnVoldewarm.Text = "Voldewarm - " + bought[2];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void btnEarthEaters_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = eartheaters.IngredientQuality + " units";
            lblFreshness.Text = eartheaters.IngredientFreshness + " units";
            lblCost.Text = "$" + eartheaters.IngredientCost;

            if (money - eartheaters.IngredientCost >= 0)
            {
                money = money - eartheaters.IngredientCost;
                UpdateMoney();

                bought[3] = bought[3] + 1;
                btnEarthEaters.Text = "Earth Eaters - " + bought[3];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void btnMuckle_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = muckle.IngredientQuality + " units";
            lblFreshness.Text = muckle.IngredientFreshness + " units";
            lblCost.Text = "$" + muckle.IngredientCost;

            if (money - muckle.IngredientCost >= 0)
            {
                money = money - muckle.IngredientCost;
                UpdateMoney();

                bought[4] = bought[4] + 1;
                btnMuckle.Text = "Muckle - " + bought[4];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void btnDirtLord_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = dirt.IngredientQuality + " units";
            lblFreshness.Text = dirt.IngredientFreshness + " units";
            lblCost.Text = "$" + dirt.IngredientCost;

            if (money - dirt.IngredientCost >= 0)
            {
                money = money - dirt.IngredientCost;
                UpdateMoney();

                bought[5] = bought[5] + 1;
                btnDirtLord.Text = "Dirt Lord - " + bought[5];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void btnHufflePuff_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = huffle.IngredientQuality + " units";
            lblFreshness.Text = huffle.IngredientFreshness + " units";
            lblCost.Text = "$" + huffle.IngredientCost;

            if (money - huffle.IngredientCost >= 0)
            {
                money = money - huffle.IngredientCost;
                UpdateMoney();

                bought[6] = bought[6] + 1;
                btnHufflePuff.Text = "Hufflepuff - " + bought[6];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void btnWhompingWifflow_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = whomping.IngredientQuality + " units";
            lblFreshness.Text = whomping.IngredientFreshness + " units";
            lblCost.Text = "$" + whomping.IngredientCost;

            if (money - whomping.IngredientCost >= 0)
            {
                money = money - whomping.IngredientCost;
                UpdateMoney();

                bought[7] = bought[7] + 1;
                btnWhompingWifflow.Text = "Whompling Wifflow - " + bought[7];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void btnWizAir_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = wizair.IngredientQuality + " units";
            lblFreshness.Text = wizair.IngredientFreshness + " units";
            lblCost.Text = "$" + wizair.IngredientCost;

            if (money - wizair.IngredientCost >= 0)
            {
                money = money - wizair.IngredientCost;
                UpdateMoney();

                bought[8] = bought[8] + 1;
                btnWizAir.Text = "WizAIRd - " + bought[8];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void btnSlytherRiver_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = slyter.IngredientQuality + " units";
            lblFreshness.Text = slyter.IngredientFreshness + " units";
            lblCost.Text = "$" + slyter.IngredientCost;

            if (money - slyter.IngredientCost >= 0)
            {
                money = money - slyter.IngredientCost;
                UpdateMoney();

                bought[9] = bought[9] + 1;
                btnSlytherRiver.Text = "Slyther - " + bought[9];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void btnGalleonOfWater_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = galleon.IngredientQuality + " units";
            lblFreshness.Text = galleon.IngredientFreshness + " units";
            lblCost.Text = "$" + galleon.IngredientCost;

            if (money - galleon.IngredientCost >= 0)
            {
                money = money - galleon.IngredientCost;
                UpdateMoney();

                bought[10] = bought[10] + 1;
                btnGalleonOfWater.Text = "Galleon of Water - " + bought[10];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void btnHogswave_Click(object sender, EventArgs e)
        {
            IngredientStats();
            lblQuality.Text = hogswave.IngredientQuality + " units";
            lblFreshness.Text = hogswave.IngredientFreshness + " units";
            lblCost.Text = "$" + hogswave.IngredientCost;

            if (money - hogswave.IngredientCost >= 0)
            {
                money = money - hogswave.IngredientCost;
                UpdateMoney();

                bought[11] = bought[11] + 1;
                btnHogswave.Text = "Hogswave - " + bought[11];
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        public void UpdateMoney()
        {
            lblMoney.Text = "$" + money;
        }


        /// <summary>
        /// Show the air ingredient stats and hide the buttons that are not apart of the air element.
        /// show the back button for the user to rechoose their intended ingredient.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAir_Click(object sender, EventArgs e)
        {
            btnFire.Hide();
            btnEarth.Hide();
            btnWater.Hide();
            pnlEarth.Hide();
            btnBack.Show();
            pnlFire.Hide();
            pnlAir.Show();
            pnlWater.Hide();
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            BoughtOutput();
            this.Close();
        }

        /// <summary>
        /// Show all the water ingredient stats and hide the buttons that are no longer needed.
        /// Show the "back" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWater_Click(object sender, EventArgs e)
        {
            btnAir.Hide();
            btnEarth.Hide();
            btnFire.Hide();
            pnlWater.Show();
            btnBack.Show();
            pnlFire.Hide();
            pnlEarth.Hide();
            pnlAir.Hide();
            
        }
        /// <summary>
        /// Create a random stat for each ingredient
        /// </summary>
        public void IngredientStats()
        {
            Random rng = new Random();
            ingredientStatsRoll = rng.Next(1, 16);

            /*lblQuality.Text = IngredientStatsRoll.ToString() + " units";
            lblFreshness.Text = IngredientStatsRoll.ToString() + " units";
            lblCost.Text = "$" + IngredientStatsRoll.ToString();*/
        }
        
        public void BoughtOutput()
        {
            using (StreamWriter file = new StreamWriter("Bought.txt"))
            {
                for (int i = 0; i < bought.Length; i++)
                {
                    file.WriteLine(bought[i]);
                }
            }
        }
    }
}
