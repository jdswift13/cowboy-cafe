using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// size of drink
        /// </summary>
        public Size Size { get; set; }
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// represents ice
        /// </summary>
        public override bool Ice { get; set; } = true;
        
        /// <summary>
        /// uint representing calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }
        /// <summary>
        /// uint representing price
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
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
                if (Lemon) instructions.Add("Add Lemon");
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }
        /// <summary>
        /// ToString function
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size + " ");
            sb.Append("Water");
            return sb.ToString();
        }

    }
}
