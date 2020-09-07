/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: SmokehouseSkeleton.cs
* Purpose: The information of ordering Smokehouse Skeleton
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class of information of ordering Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <value>
        /// Get the price
        /// </value>
        private double price = 5.62;
        public double Price
        {

            get { return price; }
        }
        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 602;
        public uint Calories
        {
            get { return calories; }
        }
        /// <value>
        /// Get and set the option of SausageLink
        /// </value>
        public bool SausageLink { get; set; } = true;
        /// <value>
        /// Get and set the option of Egg
        /// </value>
        public bool Egg { get; set; } = true;
        /// <value>
        /// Get and set the option of HashBrowns
        /// </value>
        public bool HashBrowns { get; set; } = true;
        /// <value>
        /// Get and set the option of Pancake
        /// </value>
        public bool Pancake { get; set; } = true;
        /// <value>
        /// Get the Special Instructions
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!SausageLink) specialinstructions.Add("Hold sausageLink");
                if (!Egg) specialinstructions.Add("Hold egg");
                if (!HashBrowns) specialinstructions.Add("Hold hash browns");
                if (!Pancake) specialinstructions.Add("Hold pancake");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        /// <returns>A string that name of entree</returns>    
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
