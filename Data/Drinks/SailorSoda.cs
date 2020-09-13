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
    public class SailorSoda :Drink,IOrderItem
    {
        /// <value>
        /// Get and set the Size
        /// </value>
        public override Size Size { get; set; } = Size.Small;  
        /// <value>
        /// Get and set the Soda Flavor
        /// </value>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;
        /// <value>
        /// Get the price
        /// </value>
        public override double Price
        {
            get
            {
                if(Size == Size.Small)
                {
                    return 1.42;
                }
                else if (Size == Size.Medium)
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
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 117;
                }
                else if (Size == Size.Medium)
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
        public override List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Ice) specialinstructions.Add("Hold ice");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name with Size and soda flavor
        /// </summary>
        /// <returns>A string that include name Size and flavor</returns>        
        public override string ToString()
        {
            String asize = "a";
            String aFlavor = "b";
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
            
            if (Flavor == SodaFlavor.Cherry)
            {
                aFlavor = "Cherry";
            }
            else if (Flavor == SodaFlavor.Blackberry)
            {
                aFlavor = "Blackberry";
            }
            else if (Flavor == SodaFlavor.Lemon)
            {
                aFlavor = "Lemon";
            }
            else if (Flavor == SodaFlavor.Peach)
            {
                aFlavor = "Peach";
            }
            else if (Flavor == SodaFlavor.Grapefruit)
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
