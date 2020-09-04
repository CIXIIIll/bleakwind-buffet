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
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Get the price
        /// </summary>
        private double price = 4.57;
        public double Price
        {

            get { return price; }
        }
        /// <summary>
        /// Get the calories
        /// </summary>
        private uint calories = 404;
        public uint Calories
        {
            get { return calories; }
        }

        /// <summary>
        /// Get and set the option of Broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;
        /// <summary>
        /// Get and set the option of Mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        /// <summary>
        /// Get and set the option of Tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Get and set the option of Cheddar
        /// </summary>
        public bool Cheddar { get; set; } = true;
        /// <summary>
        /// Get the Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
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
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
