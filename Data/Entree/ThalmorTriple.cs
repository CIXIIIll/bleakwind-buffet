/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: ThalmorTriple.cs
* Purpose: The information of ordering Thalmor Triple
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class ThalmorTriple
    {
        /// <summary>
        /// Get the price
        /// </summary>
        private double price = 8.32;
        public double Price
        {

            get { return price; }
        }
        /// <summary>
        /// Get the calories
        /// </summary>
        private uint calories = 943;
        public uint Calories
        {
            get { return calories; }
        }
        /// <summary>
        /// Get and set the option of Bacon
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// Get and set the option of Egg
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// Get the Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Bacon) specialinstructions.Add("Hold bacon");
                if (!Egg) specialinstructions.Add("Hold egg");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
