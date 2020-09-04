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
    public class DoubleDraugr
    {
        /// <summary>
        /// Get the price
        /// </summary>
        private double price = 7.32;
        public double Price
        {

            get { return price; }
        }
        /// <summary>
        /// Get the calories
        /// </summary>
        private uint calories = 843;
        public uint Calories
        {
            get { return calories; }
        }
        /// <summary>
        /// Get and set the option of Tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Get and set the option of Lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// Get and set the option of Mayo
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// Get and set the Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Tomato) specialinstructions.Add("Hold tomato");
                if (!Lettuce) specialinstructions.Add("Hold lettuce");
                if (!Mayo) specialinstructions.Add("Hold mayo");
                return specialinstructions;
                
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
