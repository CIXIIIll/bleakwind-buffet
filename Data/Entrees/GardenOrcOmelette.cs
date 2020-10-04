/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: GardenOrcOmelette.cs
* Purpose: The information of ordering Garden Orc Omelette
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class of information of ordering Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <value>
        /// Get the price
        /// </value>
        private double price = 4.57;
        public override double Price
        {

            get { return price; }
        }
        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 404;
        public override uint Calories
        {
            get { return calories; }
        }

        /// <value>
        /// Get and set the option of Broccoli
        /// </value>
        bool broccoli = true;
        public bool Broccoli
        {
            get { return broccoli; }
            set
            {
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <value>
        /// Get and set the option of Mushrooms
        /// </value>
        bool mushrooms = true;
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
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
        /// Get and set the option of Cheddar
        /// </value>
        bool cheddar = true;
        public bool Cheddar
        {
            get { return cheddar; }
            set
            {
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
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
                if (!Broccoli) specialinstructions.Add("Hold broccoli");
                if (!Mushrooms) specialinstructions.Add("Hold mushrooms");
                if (!Tomato) specialinstructions.Add("Hold tomato");
                if (!Cheddar) specialinstructions.Add("Hold cheddar");
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        /// <returns>A string that name of entree</returns>    
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
