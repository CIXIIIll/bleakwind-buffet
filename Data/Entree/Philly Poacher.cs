/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: Philly Poacher.cs
* Purpose: The information of ordering Philly Poacher
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class Philly_Poacher
    {
         /// <summary>
        /// Get the price
        /// </summary>
        private double price = 7.23;
        public double Price
        {

            get { return price; }
        }
        /// <summary>
        /// Get the calories
        /// </summary>
        private uint calories = 784;
        public uint Calories
        {
            get { return calories; }
        }
        /// <summary>
        /// Get and set  the option of Sirloin 
        /// </summary>
        public bool Sirloin { get; set; } = true;
        /// <summary>
        /// Get and set the option of Onion 
        /// </summary>
        public bool Onion { get; set; } = true;
        /// <summary>
        /// Get and set the option of Roll
        /// </summary>
        public bool Roll { get; set; } = true;
        /// <summary>
        /// Get and set the Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
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
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
