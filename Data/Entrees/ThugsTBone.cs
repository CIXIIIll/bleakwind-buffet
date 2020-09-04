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
    public class ThugsTBone
    {
        /// <summary>
        /// Get the price
        /// </summary>
        private double price = 6.44;
        public double Price
        {

            get { return price; }
        }
        /// <summary>
        /// Get the calories
        /// </summary>
        private uint calories = 982;
        public uint Calories
        {
            get { return calories; }
        }
        /// <summary>
        /// Get the Special Instructions
        /// </summary>
        public List<string> SpecialInstructions
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
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
