using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class which enumerates the drink object
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Double representing the price
        /// </summary>
        public abstract double Price
        {
            get;
        }
        /// <summary>
        /// Uint representing calories
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// size of drink
        /// </summary>
        public virtual Size Size { get;  }
        /// <summary>
        /// Gets Special Instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// bool representing ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;
    }
}
