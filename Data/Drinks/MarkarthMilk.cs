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
    public class MarkarthMilk : Drink, IOrderItem
    {
        /// <value>
        /// Get and set the Size
        /// </value>
        public override Size Size { get; set; } = Size.Small;
        /// <value>
        /// Get the price
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.05;
                }
                else if (Size == Size.Medium)
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
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 56;
                }
                else if (Size == Size.Medium)
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
        public override List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (Ice) specialinstructions.Add("Add ice");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name with Size
        /// </summary>
        /// <returns>A string that include name and Size</returns>      
        public override string ToString()
        {
            String asize = "a";
            if (Size == Size.Small)
            {
                asize = "Small";
            }
            else if (Size == Size.Medium)
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
