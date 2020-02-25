﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        public Size Size { get; set; }
        /// <summary>
        /// represents ice
        /// </summary>
        public override bool Ice { get; set; } = false;

        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;


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
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
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
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return 0.60;
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
                if (RoomForCream) instructions.Add("Room for Cream");
                if (Ice) instructions.Add("Add Ice");
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
            sb.Append(Size);
            if (Decaf) sb.Append(" Decaf");
            sb.Append(" Cowboy Coffee");
            //if (RoomForCream) sb.Append("with room for cream ");
            //if (RoomForCream && Ice) sb.Append("and ice");
            //else if (Ice) sb.Append("with ice");
            return sb.ToString();
        }

    }
}
