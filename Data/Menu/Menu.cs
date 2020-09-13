using System;
using System.Collections.Generic;
using System.Globalization;
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
    }
}
