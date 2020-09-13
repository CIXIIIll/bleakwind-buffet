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
    /// <summary>
    /// A class of information of ordering coffee
    /// </summary>
    public class CandlehearthCoffee :Drink, IOrderItem
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
                    return 0.75;
                }
                else if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
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
                    return 7;
                }
                else if (Size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }
        /// <value>
        /// Get and set the option of Ice
        /// </value>
        public bool Ice { get; set; } = false;
        /// <value>
        /// Get and set the option of Cream
        /// </svalue>
        public bool RoomForCream { get; set; } = false;
        /// <value>
        /// Get and set the option of Decaf
        /// </value>
        public bool Decaf { get; set; } = false;
        /// <value>
        /// Get the Special Instructions
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (Ice) specialinstructions.Add("Add ice");
                if (RoomForCream) specialinstructions.Add("Add cream");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name with Size and Decaf
        /// </summary>
        /// <returns>A string that include name Size and Decaf</returns>      
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
