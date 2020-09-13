/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: GardenOrcOmelette.cs
* Purpose: The information of ordering Garden Orc Omelette
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class of information of ordering Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <value>
        /// Get the price
        /// </value>
        private double price = 4.57;
        public override double Price
        {

            get { return price; }
        }
        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 404;
        public override uint Calories
        {
            get { return calories; }
        }

        /// <value>
        /// Get and set the option of Broccoli
        /// </value>
        public bool Broccoli { get; set; } = true;
        /// <value>
        /// Get and set the option of Mushrooms
        /// </value>
        public bool Mushrooms { get; set; } = true;
        /// <value>
        /// Get and set the option of Tomato
        /// </value>
        public bool Tomato { get; set; } = true;
        /// <value>
        /// Get and set the option of Cheddar
        /// </value>
        public bool Cheddar { get; set; } = true;
        /// <value>
        /// Get the Special Instructions
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Broccoli) specialinstructions.Add("Hold broccoli");
                if (!Mushrooms) specialinstructions.Add("Hold mushrooms");
                if (!Tomato) specialinstructions.Add("Hold tomato");
                if (!Cheddar) specialinstructions.Add("Hold cheddar");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        /// <returns>A string that name of entree</returns>    
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
