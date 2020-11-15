/*
* Author: Haoran An
* Class name: Combo.cs
* Purpose: The interface for order items
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        double Price { get; }

        uint Calories { get;}

        List<string> SpecialInstructions { get; }

        string Description { get; }
    }
}
