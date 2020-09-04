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
    public class Warrior_Water
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
                return 0;
            }
        }
        /// <summary>
        /// Get the calories
        /// </summary>
        public double Calories
        {
            get
            {
                return 0;
            }
        }
        /// <summary>
        /// Get and set the option of Ice
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Get and set the option of lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Get the Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
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

            return $"{asize} Warrior Water";
        }
    }
}
