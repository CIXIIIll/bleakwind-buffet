/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: BriarheartBurger.cs
* Purpose: The information of ordering Briarheart Burger
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class of information of ordering Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <value>
        /// Get the price
        /// </value>
        private double price = 6.32;
        public double Price
        {
            
            get { return price;  }
        }
        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 732;
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
        public bool Bun{ get; set; } = true;
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
        /// Get and set the Special Instructions
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Ketchup) specialinstructions.Add("Hold ketchup");
                if (!Bun) specialinstructions.Add("Hold bun");
                if (!Mustard) specialinstructions.Add("Hold mustard");
                if (!Pickle) specialinstructions.Add("Hold pickle");
                if (!Cheese) specialinstructions.Add("Hold cheese");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        /// <returns>A string that name of entree</returns>        
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
