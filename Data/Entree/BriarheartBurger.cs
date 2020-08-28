/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: BriarheartBurger.cs
* Purpose: The information of ordering Briarheart Burger
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class BriarheartBurger
    {
        /// <summary>
        /// Get the price
        /// </summary>
        private double price = 6.32;
        public double Price
        {
            
            get { return price;  }
        }
        /// <summary>
        /// Get the calories
        /// </summary>
        private uint calories = 732;
        public uint Calories
        {
            get { return calories; }
        }
        /// <summary>
        /// Get and set  the option of Ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Get and set the option of Bun
        /// </summary>
        public bool Bun{ get; set; } = true;
        /// <summary>
        /// Get and set the option of Mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Get and set the option of Pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Get and set the option of Cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// Get and set the Special Instructions
        /// </summary>
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
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
