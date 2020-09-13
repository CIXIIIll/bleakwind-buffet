/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: DoubleDraugr.cs
* Purpose: The information of ordering Double Draugr
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class of information of ordering Double Draugr
    /// </summary>
    public class DoubleDraugr : Entree , IOrderItem
    {
        /// <value>
        /// Get the price
        /// </value>
        private double price = 7.32;
        public override double Price
        {

            get { return price; }
        }

        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 843;
        public override uint Calories
        {
            get { return calories; }
        }
        /// <value>
        /// Get and set  the option of Ketchup
        /// </value>
        public bool Ketchup { get; set; } = true;
        /// <value>
        /// Get and set the option of Bun
        /// </value>
        public bool Bun { get; set; } = true;
        /// <value>
        /// Get and set the option of Mustard
        /// </value>
        public bool Mustard { get; set; } = true;

        /// <value>
        /// Get and set the option of Pickle
        /// </value>
        public bool Pickle { get; set; } = true;
        /// <value>
        /// Get and set the option of Cheese
        /// </value>
        public bool Cheese { get; set; } = true;
        /// <value>
        /// Get and set the option of Tomato
        /// </value>
        public bool Tomato { get; set; } = true;
        /// <value>
        /// Get and set the option of Lettuce
        /// </value>
        public bool Lettuce { get; set; } = true;
        /// <value>
        /// Get and set the option of Mayo
        /// </value>
        public bool Mayo { get; set; } = true;
        /// <value>
        /// Get and set the Special Instructions
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Ketchup) specialinstructions.Add("Hold ketchup");
                if (!Bun) specialinstructions.Add("Hold bun");
                if (!Mustard) specialinstructions.Add("Hold mustard");
                if (!Pickle) specialinstructions.Add("Hold pickle");
                if (!Cheese) specialinstructions.Add("Hold cheese");
                if (!Tomato) specialinstructions.Add("Hold tomato");
                if (!Lettuce) specialinstructions.Add("Hold lettuce");
                if (!Mayo) specialinstructions.Add("Hold mayo");
                return specialinstructions;
                
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        /// <returns>A string that name of entree</returns>    
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
