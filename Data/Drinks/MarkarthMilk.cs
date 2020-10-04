/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: MarkarthMilk.cs
* Purpose: The information of ordering milk
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class of information of ordering milk
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Get and set the Size
        /// </value>
        Size size = Size.Small;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <value>
        /// Get the price
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.05;
                }
                else if (Size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
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
                    return 56;
                }
                else if (Size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
                }
            }
        }
        bool ice = false;
        /// <value>
        /// Get and set the option of Ice
        /// </value>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get the Special Instructions
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (Ice) specialinstructions.Add("Add ice");
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

            return $"{asize} Markarth Milk";
        }
    }

}
