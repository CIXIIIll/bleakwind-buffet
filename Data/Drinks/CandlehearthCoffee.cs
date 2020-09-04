/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: CandlehearthCoffee.cs
* Purpose: The information of ordering coffee
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Get and set the size
        /// </summary>
        public Size size { get; set; } = Size.Small;
        /// <summary>
        /// Get the price
        /// </summary>
        public double Pirce
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.75;
                }
                else if (size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }
        }
        /// <summary>
        /// Get the calories
        /// </summary>
        public double Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 7;
                }
                else if (size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }
        /// <summary>
        /// Get and set the option of Ice
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Get and set the option of Cream
        /// </summary>
        public bool RppmForCream { get; set; } = false;
        /// <summary>
        /// Get and set the option of Decaf
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// Get the Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (Ice) specialinstructions.Add("Add ice");
                if (RppmForCream) specialinstructions.Add("Add cream");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name with size
        /// </summary>
        public override string ToString()
        {
            String asize = "a";
            if (size == Size.Small)
            {
                asize = "Small";
            }
            else if (size == Size.Medium)
            {
                asize = "Medium";
            }
            else
            {
                asize = "Large";
            }
            if (Decaf)
            {
                return $"{asize} Decaf Candlehearth Coffee";
            }
            else
            {
                return $"{asize} Candlehearth Coffee";
            }
        }
    }
}
