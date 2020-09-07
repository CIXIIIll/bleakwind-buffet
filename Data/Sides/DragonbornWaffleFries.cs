/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: DragonbornWaffleFries.cs
* Purpose: The information of ordering Dragonborn Waffle Fries
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class of information of ordering Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <value>
        /// Get and set the size
        /// </value>
        public Size size { get; set; } = Size.Small;
        /// <value>
        /// Get the price
        /// </value>
        public double Pirce
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.42;
                }
                else if (size == Size.Medium)
                {
                    return 0.76;
                }
                else
                {
                    return 0.96;
                }
            }
        }
        /// <value>
        /// Get the calories
        /// </value>
        public double Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 77;
                }
                else if (size == Size.Medium)
                {
                    return 89;
                }
                else
                {
                    return 100;
                }
            }
        }
        /// <value>
        /// Get the Special Instructions
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name with size
        /// </summary>
        /// <returns>A string that include name and size</returns>   
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

            return $"{asize} Dragonborn Waffle Fries";
        }
    }
}
