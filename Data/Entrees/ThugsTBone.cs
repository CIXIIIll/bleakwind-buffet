/*
* Author: Haoran An
* Edited by: Zachery Brunner
* Class name: ThugsTBone.cs
* Purpose: The information of ordering Thugs T-Bone
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class of information of ordering Thugs T-Bone
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem
    {
        /// <value>
        /// Get the price
        /// </value>
        private double price = 6.44;
        public override double Price
        {

            get { return price; }
        }
        /// <value>
        /// Get the calories
        /// </value>
        private uint calories = 982;
        public override uint Calories
        {
            get { return calories; }
        }
        /// <value>
        /// Get the Special Instructions
        /// </value>
        public override  List<string> SpecialInstructions
        {
            get
            {
                List<String> specialinstructions = new List<string>();
                return specialinstructions;
            }
        }
        /// <summary>
        /// To string the name
        /// </summary>
        /// <returns>A string that name of entree</returns>    
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
