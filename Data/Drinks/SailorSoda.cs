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
    public class SailorSoda
    {
        /// <summary>
        /// Get and set the size
        /// </summary>
        public Size size { get; set; } = Size.Small;
        /// <summary>
        /// Get and set the Soda Flavor
        /// </summary>
        public SodaFlavor SodaFlavor { get; set; } = SodaFlavor.Cherry;
        /// <summary>
        /// Get the price
        /// </summary>
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
        /// <summary>
        /// Get the calories
        /// </summary>
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
        /// <summary>
        /// Get and set the option of Ice
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Get the Special Instructions
        /// </summary>
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
            
            if (SodaFlavor == SodaFlavor.Cherry)
            {
                aFlavor = "Cherry";
            }
            else if (SodaFlavor == SodaFlavor.Blackberry)
            {
                aFlavor = "Blackberry";
            }
            else if (SodaFlavor == SodaFlavor.Lemon)
            {
                aFlavor = "Lemon";
            }
            else if (SodaFlavor == SodaFlavor.Peach)
            {
                aFlavor = "Peach";
            }
            else if (SodaFlavor == SodaFlavor.Grapefruit)
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
