using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class which represents Angry Chicken entree menu item
    /// </summary>
    public class AngryChicken : Entree
    {

        /// <summary>
        /// If dish should be served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }
        private bool bread = true;

        /// <summary>
        /// If dish should be served with pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        public override uint Calories
        {
            get
            {
                return 190;
            }
        }
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// List which holds special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread){ instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }
    }
}
