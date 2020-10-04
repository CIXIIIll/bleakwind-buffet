/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: SmokehouseSkeleton.cs
* Purpose: The information of ordering Smokehouse Skeleton
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class of information of ordering Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Get the price
        /// </value>
        private double price = 5.62;
        public override double Price
        {

            get { return price; }
        }
        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 602;
        public override uint Calories
        {
            get { return calories; }
        }
        /// <value>
        /// Get and set the option of SausageLink
        /// </value>
        bool sausagelink = true;
        public bool SausageLink
        {
            get { return sausagelink; }
            set
            {
                sausagelink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of Egg
        /// </value>
        bool egg = true;
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of HashBrowns
        /// </value>
        bool hashbrowns = true;
        public bool HashBrowns
        {
            get { return hashbrowns; }
            set
            {
                hashbrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of Pancake
        /// </value>
        bool pancake = true;
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
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
                if (!SausageLink) specialinstructions.Add("Hold sausageLink");
                if (!Egg) specialinstructions.Add("Hold egg");
                if (!HashBrowns) specialinstructions.Add("Hold hash browns");
                if (!Pancake) specialinstructions.Add("Hold pancake");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        /// <returns>A string that name of entree</returns>    
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
