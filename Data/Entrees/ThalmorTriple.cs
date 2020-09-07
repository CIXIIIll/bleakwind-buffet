/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: ThalmorTriple.cs
* Purpose: The information of ordering Thalmor Triple
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class of information of ordering Thalmor Triple
    /// </summary>
    public class ThalmorTriple
    {
        /// <value>
        /// Get the price
        /// </value>
        private double price = 8.32;
        public double Price
        {
            get { return price; }
        }
        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 943;
        public uint Calories
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
        /// Get and set the option of Bacon
        /// </value>
        public bool Bacon { get; set; } = true;
        /// <value>
        /// Get and set the option of Egg
        /// </value>
        public bool Egg { get; set; } = true;
        /// <value>
        /// Get the Special Instructions
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Bacon) specialinstructions.Add("Hold bacon");
                if (!Egg) specialinstructions.Add("Hold egg");
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
            return "Thalmor Triple";
        }
    }
}
