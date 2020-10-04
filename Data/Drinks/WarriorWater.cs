/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: Warrior Water.cs
* Purpose: The information of ordering water
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class of information of ordering water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
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
                return 0;
            }
        }
        /// <value>
        /// Get the calories
        /// </value>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }
        bool ice = true;
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
        /// Get and set the option of lemon
        /// </value>
        bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
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
                if (!Ice) specialinstructions.Add("Hold ice");
                if (Lemon) specialinstructions.Add("Add lemon");
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

            return $"{asize} Warrior Water";
        }
    }
}
