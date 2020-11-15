using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entree
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// The calories of entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// The special instruction of entree
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }
        /// <summary>
        /// The descriptions of entree
        /// </summary>
        public abstract string Description { get; }
    }
}
