using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// The size of the side
        /// </summary>

        public virtual Size Size { get; set; }
        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The calories of side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// The special instruction of side
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }
        /// <summary>
        /// The descriptions of side
        /// </summary>
        public abstract string Description { get; }
    }
}
