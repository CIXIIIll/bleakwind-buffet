/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: Warrior Water.cs
* Purpose: The information of ordering water
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class of information of ordering water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem
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
                return 0;
            }
        }
        /// <value>
        /// Get the calories
        /// </value>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }
        /// <value>
        /// Get and set the option of Ice
        /// </value>
        public bool Ice { get; set; } = true;
        /// <value>
        /// Get and set the option of lemon
        /// </value>
        public bool Lemon { get; set; } = false;
        /// <value>
        /// Get the Special Instructions
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Ice) specialinstructions.Add("Hold ice");
                if (Lemon) specialinstructions.Add("Add lemon");
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

            return $"{asize} Warrior Water";
        }
    }
}
