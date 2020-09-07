/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: SailorSoda.cs
* Purpose: The information of ordering soda
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class that get and set information of soda
    /// </summary>
    public class SailorSoda
    {
        /// <value>
        /// Get and set the size
        /// </value>
        public Size size { get; set; } = Size.Small;  
        /// <value>
        /// Get and set the Soda Flavor
        /// </value>
        public SodaFlavor sodaflavor { get; set; } = SodaFlavor.Cherry;
        /// <value>
        /// Get the price
        /// </value>
        public double Pirce
        {
            get
            {
                if(size == Size.Small)
                {
                    return 1.42;
                }
                else if (size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
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
                    return 117;
                }
                else if (size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }
        /// <value>
        /// Get and set the option of Ice
        /// </value>
        public bool Ice { get; set; } = true;
        /// <value>
        /// Get the Special Instructions
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Ice) specialinstructions.Add("Hold ice");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name with size and soda flavor
        /// </summary>
        /// <returns>A string that include name size and flavor</returns>        
        public override string ToString()
        {
            String asize = "a";
            String aFlavor = "b";
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
            
            if (sodaflavor == SodaFlavor.Cherry)
            {
                aFlavor = "Cherry";
            }
            else if (sodaflavor == SodaFlavor.Blackberry)
            {
                aFlavor = "Blackberry";
            }
            else if (sodaflavor == SodaFlavor.Lemon)
            {
                aFlavor = "Lemon";
            }
            else if (sodaflavor == SodaFlavor.Peach)
            {
                aFlavor = "Peach";
            }
            else if (sodaflavor == SodaFlavor.Grapefruit)
            {
                aFlavor = "Grapefruit";
            }
            else
            {
                aFlavor = "Watermelon";
            }

            return $"{asize} {aFlavor} Sailor Soda";
        }

    }
}
