﻿using System;
using System.Collections.Generic;
using System.Text;
namespace CowboyCafe.Data { 

public class ChiliCheeseFries : Side
{
    public override uint Calories 
    {
        get
        {
            switch (Size)
            {
                case Size.Large:
                    return 610;
                case Size.Medium:
                    return 524;
                case Size.Small:
                    return 433;
                default:
                    throw new NotImplementedException();

            }
        }
    }
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
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
            sb.Append("Chili Cheese Fries");
            return sb.ToString();
        }

    }
}