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
    public class MarkarthMilk
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
        /// <summary>
        /// Get the calories
        /// </summary>
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
        /// <summary>
        /// Get and set the option of Ice
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Get the Special Instructions
        /// </summary>
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
