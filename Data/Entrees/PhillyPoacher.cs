﻿/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: Philly Poacher.cs
* Purpose: The information of ordering Philly Poacher
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    ///  A class of information of ordering Philly Poacher
    /// </summary>
    public class PhillyPoacher: Entree, IOrderItem
    {
        /// <value>
        /// Get the price
        /// </value>
        private double price = 7.23;
        public override double Price
        {

            get { return price; }
        }
        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 784;
        public override uint Calories
        {
            get { return calories; }
        }
        /// <value>
        /// Get and set  the option of Sirloin 
        /// </value>
        public bool Sirloin { get; set; } = true;
        /// <value>
        /// Get and set the option of Onion 
        /// </value>
        public bool Onion { get; set; } = true;
        /// <value>
        /// Get and set the option of Roll
        /// </value>
        public bool Roll { get; set; } = true;
        /// <value>
        /// Get and set the Special Instructions
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Sirloin) specialinstructions.Add("Hold sirloin");
                if (!Onion) specialinstructions.Add("Hold onion");
                if (!Roll) specialinstructions.Add("Hold roll");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        /// <returns>A string that name of entree</returns>    
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}