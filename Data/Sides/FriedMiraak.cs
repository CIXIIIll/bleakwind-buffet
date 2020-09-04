/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: FriedMiraak.cs
* Purpose: The information of ordering Fried Miraak
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
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
                    return 1.78;
                }
                else if (size == Size.Medium)
                {
                    return 2.01;
                }
                else
                {
                    return 2.88;
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
                    return 151;
                }
                else if (size == Size.Medium)
                {
                    return 236;
                }
                else
                {
                    return 306;
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

            return $"{asize} Fried Miraak";
        }
    }
}
