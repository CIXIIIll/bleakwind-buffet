using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;


namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// A static class for all items on the menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// return a collection for all item on the menu
        /// </summary>
        /// <returns>a collection for all item on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> Menu = new List<IOrderItem>();
            foreach(IOrderItem x in Entrees())
            {
                Menu.Add(x);
            }
            foreach (IOrderItem x in Sides())
            {
                Menu.Add(x);
            }
            foreach (IOrderItem x in Drinks())
            {
                Menu.Add(x);
            }
            return Menu;
        }
        /// <summary>
        /// return a collection for all item in the entree
        /// </summary>
        /// <returns>a collection for all item in the entree</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> Entree = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            Entree.Add((IOrderItem)BB);
            DoubleDraugr DD = new DoubleDraugr();
            Entree.Add((IOrderItem)DD);
            GardenOrcOmelette GC = new GardenOrcOmelette();
            Entree.Add((IOrderItem)GC);
            PhillyPoacher PP = new PhillyPoacher();
            Entree.Add((IOrderItem)PP);
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Entree.Add((IOrderItem)SS);
            ThalmorTriple TT = new ThalmorTriple();
            Entree.Add((IOrderItem)TT);
            ThugsTBone TB = new ThugsTBone();
            Entree.Add((IOrderItem)TB);
            return Entree;
        }
        /// <summary>
        /// Return a collection for all item in the side
        /// </summary>
        /// <returns>a collection for all item in the side</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> Side = new List<IOrderItem>();
            for (int i = 0; i < 3; i++)
            {
                DragonbornWaffleFries SS = new DragonbornWaffleFries();
                SS.Size = (Enums.Size)i;
                Side.Add((IOrderItem)SS);
            }
            for (int i = 0; i < 3; i++)
            {
                FriedMiraak FM = new FriedMiraak();
                FM.Size = (Enums.Size)i;
                Side.Add((IOrderItem)FM);
            }
            for (int i = 0; i < 3; i++)
            {
                MadOtarGrits MG = new MadOtarGrits();
                MG.Size = (Enums.Size)i;
                Side.Add((IOrderItem)MG);
            }
            for (int i = 0; i < 3; i++)
            {
                VokunSalad VS = new VokunSalad();
                VS.Size = (Enums.Size)i;
                Side.Add((IOrderItem)VS);
            }
            return Side;
        }
        /// <summary>
        /// Return a collection for all item in the drink
        /// </summary>
        /// <returns>a collection for all item in the drink</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> Drink = new List<IOrderItem>();
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    SailorSoda SS = new SailorSoda();
                    SS.Size = (Enums.Size)i;
                    SS.Flavor = (Enums.SodaFlavor)j;
                    Drink.Add((IOrderItem)SS);
                }
            }
            for(int i = 0; i < 3; i++)
            {
                AretinoAppleJuice AJ = new AretinoAppleJuice();
                AJ.Size = (Enums.Size)i;
                Drink.Add((IOrderItem)AJ);
            }
            for (int i = 0; i < 3; i++)
            {
                CandlehearthCoffee CC = new CandlehearthCoffee();
                CC.Size = (Enums.Size)i;
                Drink.Add((IOrderItem)CC);
            }
            for (int i = 0; i < 3; i++)
            {
                MarkarthMilk MM = new MarkarthMilk();
                MM.Size = (Enums.Size)i;
                Drink.Add((IOrderItem)MM);
            }
            for (int i = 0; i < 3; i++)
            {
                WarriorWater WW = new WarriorWater();
                WW.Size = (Enums.Size)i;
                Drink.Add((IOrderItem)WW);
            }
            return Drink;

        }
        /// <summary>
        /// The type name
        /// </summary>
        public static string[] ItemsTypes
        {
            get => new string[]
            {
            "Entrees",
            "Drinks",
            "Sides",
            };
        }

        /// <summary>
        /// A collection for All items
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return FullMenu(); } }
        /// <summary>
        /// A collection for All Drinks
        /// </summary>
        public static IEnumerable<IOrderItem> Drink { get { return Drinks(); } }
        /// <summary>
        /// A collection for All Entrees
        /// </summary>
        public static IEnumerable<IOrderItem> Entree { get { return Entrees(); } }
        /// <summary>
        /// A collection for All Sides
        /// </summary>
        public static IEnumerable<IOrderItem> Side { get { return Sides(); } }
        /// <summary>
        /// Filters the provided collection of item for type
        /// </summary>
        /// <param name="items">The collection of item to filter</param>
        /// <param name="ItemsType">The item to include</param>
        /// <returns>A collection containing only items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> ItemsType)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (ItemsType.Count() == 0) return items;
            foreach (IOrderItem item in items)
            {
                if (ItemsType.Contains("Entrees") && item is Entree)
                {
                    results.Add(item);
                }
                if (ItemsType.Contains("Drinks") && item is Drink)
                {
                    results.Add(item);
                }
                if (ItemsType.Contains("Sides") && item is Side)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the provided collection of item to those with Calories falling within the speacified range
        /// </summary>
        /// <param name="items">The collection of item to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if (min == null & max == null) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min & item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the provided collection of item to those with Price falling within the speacified range
        /// </summary>
        /// <param name="items">The collection of item to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null & max == null) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min & item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Searches the Menu for matching item
        /// </summary>
        /// <param name="items">The collection of item to filter</param>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of items include terms</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return All;
            foreach(IOrderItem item in items)
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.CurrentCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }

}
