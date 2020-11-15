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
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad: Side, IOrderItem, INotifyPropertyChanged
    {
        /// <value>
        /// Cheesey Grits.
        /// </value>
        public override string Description
        {
            get
            {
                return "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Get the size
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
                    return 0.93;
                }
                else if (Size == Size.Medium)
                {
                    return 1.28;
                }
                else
                {
                    return 1.82;
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
                    return 41;
                }
                else if (Size == Size.Medium)
                {
                    return 52;
                }
                else
                {
                    return 73;
                }
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

            return $"{asize} Vokun Salad";
        }
    }
}
