/* Emily Chang
 * January 20, 2020
 * Stores all of the possible ingredients
 */
using System;
using System.Drawing;
using System.IO;

namespace HarryOtterBattle
{
    class Ingredients
    {
        // stores the name, stats and corresponding image of the ingredients
        private string name;
        private int quality;
        private int freshness;
        private int quantity;
        private string element;
        private bool error = false;
        private Image img;

        /// <summary>
        /// Create the ingredients objects
        /// </summary>
        /// <param name="fileName">the name of the file that the ingredient is saved in</param>
        public Ingredients(string fileName)
        {
            // load the files and save if there was an error
            error = Load(fileName);

            // save the correct image to each ingredient
            if (name == "Draco Malfire")
            {
                img = Properties.Resources.Draco_Malfire;
            }
            else if (name == "Heatmione")
            {
                img = Properties.Resources.Heatmione;
            }
            else if (name == "Voldewarm")
            {
                img = Properties.Resources.Voldewarm;
            }
            else if (name == "Earth Eaters")
            {
                img = Properties.Resources.Earth_Eater;
            }
            else if (name == "Muckle")
            {
                img = Properties.Resources.Muckle;
            }
            else if (name == "Dirt Lord")
            {
                img = Properties.Resources.Dirt_Lord;
            }
            else if (name == "Hufflepuff")
            {
                img = Properties.Resources.Hufflepuff;
            }
            else if (name == "Whomping Wifflow")
            {
                img = Properties.Resources.Whomping_Wifflow;
            }
            else if (name == "WizAIRd")
            {
                img = Properties.Resources.Wizaird;
            }
            else if (name == "Slyther River")
            {
                img = Properties.Resources.Slyther_River;
            }
            else if (name == "Galleon of Water")
            {
                img = Properties.Resources.Galleon_of_Water;
            }
            else if (name == "Hogswave")
            {
                img = Properties.Resources.Hogswave;
            }
            else
            {
                img = null;
            }
        }

        // load all of the ingredients and save the stats
        public bool Load(string fileName)
        {
            try
            {
                using (StreamReader file = new StreamReader(fileName))
                {
                    while (file.Peek() != -1)
                    {
                        // store the stats from what is in the file
                        name = file.ReadLine();                      
                        int.TryParse(file.ReadLine(), out quality);
                        int.TryParse(file.ReadLine(), out freshness);
                        file.ReadLine();
                        element = file.ReadLine();

                    }
                }
                return error = false;
            }
            catch (Exception e)
            {
                // return that there was an error
                return error = true;
            }
        }

        // returns the image of the ingredient
        public Image GetImage
        {
            get
            {
                return img;
            }
        }

        // returns the mame of the ingredient
        public string GetName
        {
            get
            {
                return name;
            }            
        }

        // returns the freshness of the ingredient
        public int GetFreshness
        {
            get
            {
                return freshness;
            }
        }

        // returns the quality of the ingredient
        public int GetQuality
        {
            get
            {
                return quality;
            }
        }
        
        // returns the quantity of the ingredient, also allows the quantity value to be changed
        public int GetQuantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        // return the element of the ingredient
        public string GetElement
        {
            get
            {
                return element;
            }
        }

        // returns if there was an error loading
        public bool GetError
        {
            get
            {
                return error;
            }
        }
    }
}
