
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        IOrderItem drink;

        IOrderItem entree;

        IOrderItem side;

        public IOrderItem Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public IOrderItem Entree
        {
            get { return entree; }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        public IOrderItem Side
        {
            get { return side; }
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        public double Price
        {
            get
            {
                double price = 0;
                if(drink != null)
                {
                    price += drink.Price;
                }
                if(side != null)
                {
                    price += side.Price;
                }
                if(entree != null)
                {
                    price += entree.Price;
                }
                price -= 1;
                return price;
            }
        }

        public uint Calories
        {
            get
            {
                uint calories = 0;
                if (drink != null)
                {
                    calories += drink.Calories;
                }
                if (side != null)
                {
                    calories += side.Calories;
                }
                if (entree != null)
                {
                    calories += entree.Calories;
                }
                return calories;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (drink != null)
                {
                    specialInstructions.Add(drink.ToString());
                    specialInstructions.Add(" ");
                    foreach (string s in drink.SpecialInstructions)
                    {
                        specialInstructions.Add(s);
                        specialInstructions.Add(",");
                    }
                    specialInstructions.Add(",");
                }
                if (side != null)
                {
                    specialInstructions.Add(side.ToString());
                    specialInstructions.Add(" ");
                    foreach (string s in side.SpecialInstructions)
                    {
                        specialInstructions.Add(s);
                        specialInstructions.Add(",");
                    }
                    specialInstructions.Add(",");
                }
                if (entree != null)
                {
                    specialInstructions.Add(entree.ToString());
                    specialInstructions.Add(" ");
                    foreach (string s in entree.SpecialInstructions)
                    {
                        specialInstructions.Add(s);
                        specialInstructions.Add(",");
                    }
                    specialInstructions.Add(",");
                }
                specialInstructions.Add(" ");
                specialInstructions.Add(",");
                return specialInstructions;
            }
        }
    }
}
