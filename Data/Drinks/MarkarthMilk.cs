/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: MarkarthMilk.cs
* Purpose: The information of ordering milk
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class of information of ordering milk
    /// </summary>
    public class MarkarthMilk
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
                    return 1.05;
                }
                else if (size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
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
                    return 56;
                }
                else if (size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
                }
            }
        }
        /// <value>
        /// Get and set the option of Ice
        /// </value>
        public bool Ice { get; set; } = false;
        /// <value>
        /// Get the Special Instructions
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (Ice) specialinstructions.Add("Add ice");
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

            return $"{asize} Markarth Milk";
        }
    }

}
