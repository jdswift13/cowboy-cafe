using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        public Size Size { get; set; }
        /// <summary>
        /// represents ice
        /// </summary>
        public override bool Ice { get; set; } = true;
        /// <summary>
        /// represents soda flavor
        /// </summary>
        public SodaFlavor Flavor { get; set; }
        /// <summary>
        /// uint representing calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException();

                }
            }
        }
        /// <summary>
        /// uint representing price
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException();
                }
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

                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }
    }
}
