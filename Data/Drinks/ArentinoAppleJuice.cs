/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: ArentinoAppleJuice.cs
* Purpose: The information of ordering apple juice
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    
    public class ArentinoAppleJuice
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
                    return 0.62;
                }
                else if (size == Size.Medium)
                {
                    return 0.87;
                }
                else
                {
                    return 1.01;
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
                    return 44;
                }
                else if (size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
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

            return $"{asize} Aretino Apple Juice";
        }
    }
}
