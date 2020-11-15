/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: BriarheartBurger.cs
* Purpose: The information of ordering Briarheart Burger
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class of information of ordering Briarheart Burger
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Get the price
        /// </value>
        private double price = 6.32;
        public override double Price
        {
            
            get { return price;  }
        }
        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 732;
        public override uint Calories
        {
            get { return calories; }
        }
        /// <value>
        /// Get and set  the option of Ketchup
        /// </value>
        bool ketchup = true;
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of Bun
        /// </value>
        bool bun = true;
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of Mustard
        /// </value>
        bool mustard = true;
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of Pickle
        /// </value>
        bool pickle = true;
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of Cheese
        /// </value>
        bool cheese = true;
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the Special Instructions
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Ketchup) specialinstructions.Add("Hold ketchup");
                if (!Bun) specialinstructions.Add("Hold bun");
                if (!Mustard) specialinstructions.Add("Hold mustard");
                if (!Pickle) specialinstructions.Add("Hold pickle");
                if (!Cheese) specialinstructions.Add("Hold cheese");
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
                return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        /// <returns>A string that name of entree</returns>        
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
