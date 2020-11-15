/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: ArentinoAppleJuice.cs
* Purpose: The information of ordering apple juice
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class of information of ordering apple juice
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
   
        /// <value>
        /// Get the price
        /// </value>
        public override double Price
        {
            get { 
                if (Size == Size.Small)
                {
                    return 0.62;
                }
                else if (Size == Size.Medium)
                {
                    return 0.87;
                }
                else
                {
                    return 1.01;
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
                    return 44;
                }
                else if (Size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
                }
            }
        }
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
        bool ice = false;
        /// <value>
        /// Get and set the option of Ice
        /// </value>

        public bool Ice { 
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
        /// <value>
        /// Get the Description
        /// </value>
        public override string Description
        {
            get
            {
                return "Fresh squeezed apple juice.";
            }
        }
        /// <summary>
        /// To string the name with Size
        /// </summary>
        /// <returns>A string that include name and Size</returns>      
        public override string ToString()
        {
            return $"{Size.ToString()} Aretino Apple Juice";
  
        }
    }
}
