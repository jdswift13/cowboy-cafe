using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// size of drink
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// represents ice
        /// </summary>
        public override bool Ice { get; set; } = true;
        /// <summary>
        /// represents soda flavor
        /// </summary>
        public  SodaFlavor Flavor { get; set; }
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
        /// <summary>
        /// ToString function
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size + " ");
            if (Flavor == SodaFlavor.BirchBeer) sb.Append("Birch Beer ");
            if (Flavor == SodaFlavor.OrangeSoda) sb.Append("Orange Soda ");
            if (Flavor == SodaFlavor.RootBeer) sb.Append("Root Beer ");
            if (Flavor == SodaFlavor.CreamSoda) sb.Append("Cream Soda ");
            if (Flavor == SodaFlavor.Sarsparilla) sb.Append("Sarsparilla ");

            sb.Append("Jerked Soda");
            return sb.ToString();
        }

    }
}
