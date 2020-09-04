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
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Get the price
        /// </summary>
        private double price = 5.62;
        public double Price
        {

            get { return price; }
        }
        /// <summary>
        /// Get the calories
        /// </summary>
        private uint calories = 602;
        public uint Calories
        {
            get { return calories; }
        }
        /// <summary>
        /// Get and set the option of SausageLink
        /// </summary>
        public bool SausageLink { get; set; } = true;
        /// <summary>
        /// Get and set the option of Egg
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// Get and set the option of HashBrowns
        /// </summary>
        public bool HashBrowns { get; set; } = true;
        /// <summary>
        /// Get and set the option of Pancake
        /// </summary>
        public bool Pancake { get; set; } = true;
        /// <summary>
        /// Get the Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!SausageLink) specialinstructions.Add("Hold sausageLink");
                if (!Egg) specialinstructions.Add("Hold egg");
                if (!HashBrowns) specialinstructions.Add("Hold hash brownsd");
                if (!Pancake) specialinstructions.Add("Hold pancake");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
