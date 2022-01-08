/* Emily Chang
 * January 20, 2020
 * Allow the user to create spells and scroll through ingredients. Ends the program when the user runs out of time, creates a spell or doesn't successfully create a spell. Has all of the buttons ie. Create. 
 */
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarryOtterBattle
{
    public partial class SpellMakingForm : Form
    {
        // store the index of the ingredient being displayed in the picture box
        private int ingredientIndex = 0;
        
        // store all of the ingredients in the game
        private List<Ingredients> ingredients = new List<Ingredients>();

        // stores all of the ingredients that the user bought
        private List<Ingredients> purchased = new List<Ingredients>();

        // store the ingredients that the player chooses
        private List<Ingredients> available = new List<Ingredients>();

        // store if the player was able to create a spell or not
        private bool spellFailed = false;

        // store if the player chose their first ingredient or not
        private bool firstIngredientChosen = false;

        // store if the player chose their second ingredient or not
        private bool secondIngredientChosen = false;

        // the spell that the player creates
        private Spell theSpell = new Spell(null, null);

        // the combo spell
        private Spell combo;

        // the RecipeBook object that will have a list of recipes
        private RecipeBook recipeBook;

        // stores whether or not the player chooses to create a combo spell
        private bool comboChoice = false;

        // store how many seconds the player has left to finish the game
        private int timer = 10;

        // stores the sum of all of the quantities of ingredients
        // sum is equal to 1 in the beginnning so that ingredients will display properly
        int sum = 1;

        public SpellMakingForm()
        {
            InitializeComponent();

            // create all the ingredients, recipes and load the ingredients that the user has purchased
            AddIngredients();
            AddRecipeBook();
            LoadPurchasedIngredients();

            // display everything in the user interface and check to see which index to start at
            CheckIngredient();
            Display();   
            
            // starts the timer and displays it
            tmrDisplayTime.Enabled = true;
            DisplayTime();       
        }

        // check to see if the user has that ingredient
        private void CheckIngredient()
        {
            // finds the next index that the user has an ingredient at and save it
            while (purchased[ingredientIndex].GetQuantity == 0)
            {
                if (purchased[ingredientIndex].GetQuantity == 0)
                {
                    ingredientIndex++;
                    if (ingredientIndex >= purchased.Count)
                    {
                        ingredientIndex = 0;
                    }
                }
            }
        }

        private void AddIngredients()
        {
            // create all of the ingredient objects and add them to the ingredients list
            ingredients.Add(new Ingredients("Draco.txt"));
            ingredients.Add(new Ingredients("Heatmione.txt"));
            ingredients.Add(new Ingredients("Voldewarm.txt"));
            ingredients.Add(new Ingredients("Earth.txt"));
            ingredients.Add(new Ingredients("Muckle.txt"));
            ingredients.Add(new Ingredients("Dirt.txt"));
            ingredients.Add(new Ingredients("Huffle.txt"));
            ingredients.Add(new Ingredients("Whomping.txt"));
            ingredients.Add(new Ingredients("Wizair.txt"));
            ingredients.Add(new Ingredients("Slyter.txt"));
            ingredients.Add(new Ingredients("Galleon.txt"));
            ingredients.Add(new Ingredients("Hogswave.txt"));

            // checks to see if there was an error loading the files
            for (int i = 0; i < ingredients.Count; i++)
            {
                if (ingredients[i].GetError == true)
                {
                    MessageBox.Show("Error reading file");
                }
            }
        }

        // load the ingredients that the player has bought
        private void LoadPurchasedIngredients()
        {
            // used to store which line in the file the program is reading
            int count = 0;
            try
            {
                // read Bought.txt
                using (StreamReader file = new StreamReader("Bought.txt"))
                {
                    // keep reading until the end of the file
                    while (file.Peek() != -1)
                    {
                        // stores the quantity that the user has bought
                        int temp;
                        int.TryParse(file.ReadLine(), out temp);

                        // changes the quantity of that ingredient 
                        ingredients[count].GetQuantity = temp;
                        purchased.Add(ingredients[count]);

                        // increase the count to remain accurate to the line that the program is reading
                        count++;
                    }
                }
            }
            catch (Exception e)
            {
                // if there was an error loading the file, display this message
                MessageBox.Show("Error reading file");
            }
        }

        private void AddRecipeBook()
        {
            // creates the RecipeBook with the ingredients that were just created
            recipeBook = new RecipeBook(ingredients);
            // if the RecipeBook file doesn't input correctly display the error message
            if (recipeBook.GetError == true)
            {
                // display error message and hide everything else
                MessageBox.Show("Error reading file");
            }
        }

        // show the next ingredient
        private void btnNext_Click(object sender, EventArgs e)
        {
            // add one to the ingredientIndex because when the program starts it already displays the first index
            ingredientIndex++;

            // if the index is larger than the amount of ingredients, loop back to the beginning of the list
            if (ingredientIndex >= purchased.Count)
            {
                ingredientIndex = 0;
            }

            // loop forwards until the program finds an ingredient that the user has in case the current ingredientIndex doesn't contain an ingredient that the user has
            while (purchased[ingredientIndex].GetQuantity == 0)
            {
                if (purchased[ingredientIndex].GetQuantity == 0)
                {
                    ingredientIndex++;
                    if (ingredientIndex >= purchased.Count)
                    {
                        ingredientIndex = 0;
                    }
                }
            }
           
            // display the next ingredient
            Display();
        }

        // show the previous ingredient
        private void btnBack_Click(object sender, EventArgs e)
        {
            // subtract one to the ingredientIndex because when the program starts it already displays the first index
            ingredientIndex--;

            // if the index is less than zero, loop to the end of the list
            if (ingredientIndex < 0)
            {
                ingredientIndex = purchased.Count - 1;
            }

            // loop backwards until the program finds an ingredient that the user has in case the current ingredientIndex doesn't contain an ingredient that the user has
            while (purchased[ingredientIndex].GetQuantity == 0)
            {
                if (purchased[ingredientIndex].GetQuantity == 0)
                {
                    ingredientIndex--;
                    if (ingredientIndex < 0)
                    {
                        ingredientIndex = purchased.Count - 1;
                    }
                }
            }    

            // display the previous ingredient 
            Display();
        }

        // display the current ingredient
        public void Display()
        {
            // displays the ingredients if the user has some
            if (sum != 0)
            {    
                // display the current ingredient in the picture box and display its stats in the labels
                picInventory.Image = purchased[ingredientIndex].GetImage;
                lblName.Text = purchased[ingredientIndex].GetName;
                lblFreshness.Text = "Freshness: " + purchased[ingredientIndex].GetFreshness.ToString();
                lblQuality.Text = "Quality: " + purchased[ingredientIndex].GetQuality.ToString();
                lblQuantity.Text = "Quantity: " + purchased[ingredientIndex].GetQuantity.ToString();
                lblElement.Text = "Element: " + purchased[ingredientIndex].GetElement;
            }
            else
            {
                // display nothing as the user has no ingredients
                picInventory.Image = null;
                lblName.Text = "";
                lblFreshness.Text = "Freshness: ";
                lblQuality.Text = "Quality: ";
                lblQuantity.Text = "Quantity: ";
                lblElement.Text = "Element: ";
            }
        }

        // creates and checks if the spell exists
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // store the recipe that the player uses or null if the player did not successfully create a recipe
            Recipes spellRecipe = recipeBook.CheckSpell(recipeBook.GetRecipes, available);

            // runs the first time the player creates a spell
            if (comboChoice == false)
            {
                // if the spellRecipe is null, the spell failed
                if (spellRecipe == null)
                {
                    spellFailed = true;
                    SpellFailed();
                }
                // create the spell if it exists and start the win sequence
                else
                {
                    theSpell = new Spell(spellRecipe, available);
                    Win();
                }

                // output the spell the player creates
                theSpell.SpellOutput(comboChoice);

                // if there is an error with outputting the spell, display the error message
                if (theSpell.GetError == true)
                {
                    MessageBox.Show("Error writing to file");
                }
            }
            // runs if the player decides to create a combo spell
            else
            {
                // creates the combo spell
                combo = new Spell(spellRecipe, available);

                // output the spell the player creates
                combo.SpellOutput(comboChoice);

                // if the spellRecipe is null, the spell failed
                if (spellRecipe == null)
                {
                    spellFailed = true;
                    SpellFailed();
                }
                // create the spell if it exists and show the win screen
                else
                {
                    // sets both of the combo booleans to false to prevent errors and allow the program to close smoothly
                    comboChoice = false;
                    recipeBook.GetCombo = false;

                    // show the endscreen and start to timer to close the program
                    Win();
                }

                // if there is an error with outputting the spell, display the error message
                if (combo.GetError == true)
                {
                    MessageBox.Show("Error writing to file");
                }
            } 
        }

        // make everything in the user interface not visible
        private void HideEverything()
        {
            picIngredient1.Visible = picIngredient2.Visible = picInventory.Visible = lblFreshness.Visible = lblElement.Visible = lblName.Visible = lblQuality.Visible = lblQuantity.Visible = lblTime.Visible = btnCreate.Visible = btnBack.Visible = btnNext.Visible = false;
            picFlame1.Visible = picFlame2.Visible = picLeaf1.Visible = picLeaf2.Visible = picAir1.Visible = picAir2.Visible = picWater1.Visible = picWater2.Visible = false;
            lblFlame.Visible = lblLeaf.Visible = lblAir.Visible = lblWater.Visible = false;
            lblPlus.Visible = lblPlus2.Visible = lblPlus3.Visible = lblPlus4.Visible = false;
        }

        // win runs when the player has successfully created a spell
        private void Win()
        {
            // stop the timer that will end the game
            tmrDisplayTime.Enabled = false;

            // hide everything in the user interface
            HideEverything();

            // display the combo spell menu if the player created a spell that could be in a combo spell
            if (recipeBook.GetCombo == true)
            {
                this.BackgroundImage = Properties.Resources.blank;
                lblComboSpell.Visible = btnYes.Visible = btnNo.Visible = true;
            }
            // if the spell created is not apart of the combo spell, output the quanities the user has and close the form
            else
            {
                PurchasedOutput();
                this.Close();
            }
           
        }

        // runs when the player did not create a spell or ran out of time
        private void SpellFailed()
        {
            // stop the countdown
            tmrDisplayTime.Enabled = false;

            // output purchased ingredients
            PurchasedOutput();

            // close the program
            this.Close();
        }

        private void picInventory_Click(object sender, EventArgs e)
        {
            // create an ingredintChosen object
            Ingredients ingredientChosen;
            
            // stores the quanitity of the chosen ingredient
            int tempQuantity = purchased[ingredientIndex].GetQuantity;

            // sets sum to zero so that it can be calculated properly later on in the subprogram
            sum = 0;

            // doesn't allow the user to change their ingredient choice after they choose it, also won't let the user choose the ingredient if the quantity is 0
            if (secondIngredientChosen != true && tempQuantity != 0)
            {
                // saves the ingredient that the player selects into the ingredientChosen object
                ingredientChosen = purchased[ingredientIndex];

                // decreases the ingredients quanity by 1
                purchased[ingredientIndex].GetQuantity = tempQuantity - 1;
             
                // add the ingredient the player chose into the available list
                available.Add(ingredientChosen);

                // the ingredientChosen will appear in picIngredient1 if it is the first ingredient chosen and it will appear in picIngredient2 if it isn't
                if (firstIngredientChosen == false)
                {
                    picIngredient1.Image = purchased[ingredientIndex].GetImage;
                }
                else if (firstIngredientChosen == true)
                {
                    picIngredient2.Image = purchased[ingredientIndex].GetImage;
                    // sets secondIngredientChosen to true so that the user cannot change the ingredient after they choose it
                    secondIngredientChosen = true;
                }

                // set firstIngredientChosen equal to true after the player chooses the first ingredient
                firstIngredientChosen = true;

                // sum up the total number of ingredient quanitites
                for (int i = 0; i < purchased.Count; i++)
                {
                    sum = sum + purchased[i].GetQuantity;
                }

                // only display this message if they haven't chosen their second ingredient yet and they have no more ingredients
                if (secondIngredientChosen == false && sum == 0)
                {
                    // inform the user they have no more ingredients
                    MessageBox.Show("You have no more ingredients");
                    // output the quanities of the ingredients
                    PurchasedOutput();
                    // output that the spell failed as there are no other ingredients left
                    theSpell.SpellOutput(comboChoice);
                    // close the program and return
                    this.Close();
                    return;
                }

                // if the user still has ingredients left, find the next index that the user has an ingredient at
                if (sum != 0)
                {
                    // remove the ingredient from the purchased list if there is no more left
                    if (purchased[ingredientIndex].GetQuantity <= 0)
                    {
                        // loop until the program finds an ingredient that the user has
                        CheckIngredient();
                    }
                }

                // update the display as the user might have used up all of one ingredient
                Display();
                // display the open cauldron
                this.BackgroundImage = Properties.Resources.Cauldron_Open_Background;
            }          
        }
        
        // diplay the time that the player has remaining
        private void DisplayTime()
        {
            // display the time remaining into the label
            lblTime.Text = timer.ToString();

            // decrease the time remaining by one
            timer--;

            // if they run out of time, end the program and output that the spell failed and the updated quanities
            if (timer < 0)
            {
                tmrDisplayTime.Enabled = false;
                PurchasedOutput();
                theSpell.SpellOutput(comboChoice);
                MessageBox.Show("You ran out of time.");
                this.Close();
            }
        }

        // display a countdown that changes every second
        private void tmrDisplayTime_Tick(object sender, EventArgs e)
        {
            DisplayTime();
        }

        // if the player clicks no, end the program and output the remaining ingredient quanities
        private void btnNo_Click(object sender, EventArgs e)
        {
            tmrDisplayTime.Enabled = false;
            PurchasedOutput();
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // add 5 more seconds to the time remaining for the player to create the combo spell
            timer = timer + 5;
            // start the timer again
            tmrDisplayTime.Enabled = true;

            // reset the firstIngredientChosen boolean so that the player will be able to properly choose ingredients again
            firstIngredientChosen = false;
            secondIngredientChosen = false;
            // set comboChoice equal to true
            comboChoice = true;

            // hide everything to do with the combo spell choice
            lblComboSpell.Visible = btnYes.Visible = btnNo.Visible = false;
            // show everything again so that it is the same as when the game first started
            ShowEverything();

            // remove the images in the ingredient chosen picture boxes
            picIngredient1.Image = null;
            picIngredient2.Image = null;

            // set the ingredientIndex to 0 so that it will display the first ingredient again then check it so that it will find the first ingredient that the user still has
            ingredientIndex = 0;
            CheckIngredient();
            Display();

            // set the background to the original background image
            this.BackgroundImage = Properties.Resources.New_Background;

            // clear the list of ingredients that the player chose before
            available.Clear();
        }

        // output the new quantities
        private void PurchasedOutput()
        {
            try
            {
                // overwrite the Bought.txt file with the updated quantities
                using (StreamWriter file = new StreamWriter("Bought.txt"))
                {
                    for (int i = 0; i < purchased.Count; i++)
                    {
                        file.WriteLine(purchased[i].GetQuantity);
                    }
                }
            }
            catch (Exception e)
            {
                // if there is an error, inform the user
                MessageBox.Show("Error writing to file");
            }
        }

        // show almost everything that is shown in the program when it starts up
        private void ShowEverything()
        {
            picIngredient1.Visible = picIngredient2.Visible = picInventory.Visible = lblFreshness.Visible = lblElement.Visible = lblName.Visible = lblQuality.Visible = lblQuantity.Visible = lblTime.Visible = btnCreate.Visible = btnBack.Visible = btnNext.Visible = true;
            
        }

        // takes the user into the recipe book screen
        private void picBook_Click(object sender, EventArgs e)
        {
            // changes the background to the recipe book
            this.BackgroundImage = Properties.Resources.Recipe_Book;
            // displays everything in the recipe book and hides everything that is unnecessary 
            btnBackToSpell.Visible = true;
            picFlame1.Visible = picFlame2.Visible = picLeaf1.Visible = picLeaf2.Visible = picAir1.Visible = picAir2.Visible = picWater1.Visible = picWater2.Visible = true;
            lblFlame.Visible = lblLeaf.Visible = lblAir.Visible = lblWater.Visible = true;
            lblPlus.Visible = lblPlus2.Visible = lblPlus3.Visible = lblPlus4.Visible = true;
            picIngredient1.Visible = picIngredient2.Visible = picInventory.Visible = lblFreshness.Visible = lblElement.Visible = lblName.Visible = lblQuality.Visible = lblQuantity.Visible = btnCreate.Visible = btnBack.Visible = btnNext.Visible = false;
        }

        // takes the user back to the spell making screen
        private void btnBackToSpell_Click(object sender, EventArgs e)
        {
            // changes the background back to the original background
            this.BackgroundImage = Properties.Resources.New_Background;
            // displays everything in the original spell making screen and hides everything that is unnecessary
            btnBackToSpell.Visible = false;
            picFlame1.Visible = picFlame2.Visible = picLeaf1.Visible = picLeaf2.Visible = picAir1.Visible = picAir2.Visible = picWater1.Visible = picWater2.Visible = false;
            lblFlame.Visible = lblLeaf.Visible = lblAir.Visible = lblWater.Visible = false;
            lblPlus.Visible = lblPlus2.Visible = lblPlus3.Visible = lblPlus4.Visible = false;
            picIngredient1.Visible = picIngredient2.Visible = picInventory.Visible = lblFreshness.Visible = lblElement.Visible = lblName.Visible = lblQuality.Visible = lblQuantity.Visible = btnCreate.Visible = btnBack.Visible = btnNext.Visible = true;
        }
    }
}