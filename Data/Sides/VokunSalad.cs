/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: VokunSalad.cs
* Purpose: The information of ordering Vokun Salad.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
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
                    return 0.93;
                }
                else if (size == Size.Medium)
                {
                    return 1.28;
                }
                else
                {
                    return 1.82;
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
                    return 41;
                }
                else if (size == Size.Medium)
                {
                    return 52;
                }
                else
                {
                    return 73;
                }
            }
        }
        /// <summary>
        /// Get the Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name and size
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

            return $"{asize} Vokun Salad";
        }
    }
}
