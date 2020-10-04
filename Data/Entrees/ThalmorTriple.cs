/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: ThalmorTriple.cs
* Purpose: The information of ordering Thalmor Triple
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class of information of ordering Thalmor Triple
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Get the price
        /// </value>
        private double price = 8.32;
        public override double Price
        {
            get { return price; }
        }
        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 943;
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
        /// Get and set the option of Tomato
        /// </value>
        bool tomato = true;
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of Lettuce
        /// </value>
        bool lettuce = true;
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of Mayo
        /// </value>
        bool mayo = true;
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of Bacon
        /// </value>
        bool bacon = true;
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
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
        /// Get the Special Instructions
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                if (!Bacon) specialinstructions.Add("Hold bacon");
                if (!Egg) specialinstructions.Add("Hold egg");
                if (!Ketchup) specialinstructions.Add("Hold ketchup");
                if (!Bun) specialinstructions.Add("Hold bun");
                if (!Mustard) specialinstructions.Add("Hold mustard");
                if (!Pickle) specialinstructions.Add("Hold pickle");
                if (!Cheese) specialinstructions.Add("Hold cheese");
                if (!Tomato) specialinstructions.Add("Hold tomato");
                if (!Lettuce) specialinstructions.Add("Hold lettuce");
                if (!Mayo) specialinstructions.Add("Hold mayo");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        /// <returns>A string that name of entree</returns>    
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
