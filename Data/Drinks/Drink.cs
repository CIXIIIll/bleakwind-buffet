﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
    
        public virtual Size Size { get; set; }
        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The calories of drink
        /// </summary>
        public abstract uint Calories { get;}
        /// <summary>
        /// The special instruction of drink
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }
        /// <summary>
        /// The descriptions of drink
        /// </summary>
        public abstract string Description { get; }
    }
}
