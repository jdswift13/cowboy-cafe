using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class which represents Angry Chicken entree menu item
    /// </summary>
    public class AngryChicken
    {

        /// <summary>
        /// If dish should be served with bread
        /// </summary>
        public bool Bread
        {
            get { return Bread; }
            set { Bread = value; }
        }
        private bool bread = true;

        /// <summary>
        /// If dish should be served with pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Price of dish
        /// </summary>
        public double Price
        {
            get { return 5.99; }
        }
            
        /// <summary>
        /// Calories in dish
        /// </summary>
        public uint Calories
        {
            get { return 190; }
        }

        /// <summary>
        /// List which holds special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!bread){ instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }
    }
}
