/*
* Author: Haoran An
* Class name: MenuSelection.xaml.cs
* Purpose: Interaction logic for MenuSelection.xaml 
*/
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.DrinksMenu;
using PointOfSale.EntreesMenu;
using PointOfSale.SidesMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        IOrderItem item;
        /// <summary>
        /// Constructs a new MenuSelection
        /// </summary>
        public bool Combobool;
        ComboMenu m;
        public MenuSelection()
        {
            InitializeComponent();
        }
        /// <summary> 
        /// Open the Briarheart Burger list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        void AddBriarheartBurger(object sender, EventArgs e)
        {
            BriarheartBurgerMenu b = new BriarheartBurgerMenu();
            Done.Visibility = Visibility.Visible;
            Container.Child = b;
            b.DataContext = new BriarheartBurger();
            item = (IOrderItem)b.DataContext;
        }
        /// <summary> 
        /// Adds the item in the list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            Done.Visibility = Visibility.Hidden;
            if (Combobool)
            {
                Container.Child = m;
                if(item is Drink items)
                {
                    if(m.DataContext is Combo com)
                    {
                        com.Drink = (IOrderItem)items;
                    }
                }
                if (item is Entree entree)
                {
                    if (m.DataContext is Combo com)
                    {
                        com.Entree = (IOrderItem)entree;
                    }
                }
                if (item is Side side)
                {
                    if (m.DataContext is Combo com)
                    {
                        com.Side = (IOrderItem)side;
                    }
                }
            }
            else
            {
                if (DataContext is Order order)
                {
                    order.Add(item);
                }
                Container.Child = null;
            }
            item = null;
        }
        /// <summary> 
        /// Open the Double Draugr list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddDoubleDraugr(object sender, RoutedEventArgs e)
        {
            DoubleDraugrMenu d = new DoubleDraugrMenu();
            Done.Visibility = Visibility.Visible;
            d.DataContext = new DoubleDraugr();
            Container.Child = d;
            item = (IOrderItem)d.DataContext;
        }
        /// <summary> 
        /// Open the Garden Orc Omelette list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            GardenOrcOmeletteMenu g = new GardenOrcOmeletteMenu();
            Done.Visibility = Visibility.Visible;
            g.DataContext = new GardenOrcOmelette();
            Container.Child = g;
            item = (IOrderItem)g.DataContext;
        }
        /// <summary> 
        /// Open the Thalmor Triple list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddThalmorTriple(object sender, RoutedEventArgs e)
        {
            ThalmorTripleMenu tt = new ThalmorTripleMenu();
            Done.Visibility = Visibility.Visible;
            tt.DataContext = new ThalmorTriple();
            Container.Child = tt;
            item = (IOrderItem)tt.DataContext;
        }
        /// <summary> 
        /// Open the Smokehouse Skeleton list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeletonMenu s = new SmokehouseSkeletonMenu();
            Done.Visibility = Visibility.Visible;
            s.DataContext = new SmokehouseSkeleton();
            Container.Child = s;
            item = (IOrderItem)s.DataContext;
        }
        /// <summary> 
        /// Open the Philly Poacher list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddPhillyPoacher(object sender, RoutedEventArgs e)
        {
            PhillyPoacherMenu p = new PhillyPoacherMenu();
            Done.Visibility = Visibility.Visible;
            p.DataContext = new PhillyPoacher();
            Container.Child = p;
            item = (IOrderItem)p.DataContext;
        }
        /// <summary> 
        /// Open the Thugs T Bone list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddThugsTBone(object sender, RoutedEventArgs e)
        {
            ThugsTBoneMenu t = new ThugsTBoneMenu();
            Done.Visibility = Visibility.Visible;
            t.DataContext = new ThugsTBone();
            Container.Child = t;
            item = (IOrderItem)t.DataContext;
        }
        /// <summary> 
        /// Open the Sailor Soda list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddSailorSoda(object sender, RoutedEventArgs e)
        {
            SailorSodaMenu s = new SailorSodaMenu();
            Done.Visibility = Visibility.Visible;
            s.DataContext = new SailorSoda();
            Container.Child = s;
            item = (IOrderItem)s.DataContext;
        }
        /// <summary> 
        /// Open the Markarth Milklist list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddMarkarthMilk(object sender, RoutedEventArgs e)
        {
            MarkarthMilkMenu mm = new MarkarthMilkMenu();
            Done.Visibility = Visibility.Visible;
            mm.DataContext = new MarkarthMilk();
            Container.Child = mm;
            item = (IOrderItem)mm.DataContext;
        }
        /// <summary> 
        /// Open the Aretino Apple Juice list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuiceMenu a = new AretinoAppleJuiceMenu();
            Done.Visibility = Visibility.Visible;
            a.DataContext = new AretinoAppleJuice();
            Container.Child = a;
            item = (IOrderItem)a.DataContext;
        }
        /// <summary> 
        /// Open the Candlehearth Coffee list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffeeMenu c = new CandlehearthCoffeeMenu();
            Done.Visibility = Visibility.Visible;
            c.DataContext = new CandlehearthCoffee();
            Container.Child = c;
            item = (IOrderItem)c.DataContext;
        }
        /// <summary> 
        /// Open the Warrior Water list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddWarriorWater(object sender, RoutedEventArgs e)
        {
            WarriorWaterMenu w = new WarriorWaterMenu();
            Done.Visibility = Visibility.Visible;
            w.DataContext = new WarriorWater();
            Container.Child = w;
            item = (IOrderItem)w.DataContext;
        }
        /// <summary> 
        /// Open the Vokun Salad list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddVokunSalad(object sender, RoutedEventArgs e)
        {
            VokunSaladMenu v = new VokunSaladMenu();
            Done.Visibility = Visibility.Visible;
            v.DataContext = new VokunSalad();
            Container.Child = v;
            item = (IOrderItem)v.DataContext;
        }
        /// <summary> 
        /// Open the Fried Miraak list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddFriedMiraak(object sender, RoutedEventArgs e)
        {
            FriedMiraakMenu f = new FriedMiraakMenu();
            Done.Visibility = Visibility.Visible;
            f.DataContext = new FriedMiraak();
            Container.Child = f;
            item = (IOrderItem)f.DataContext;
        }
        /// <summary> 
        /// Open the Mad Otar Grits list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddMadOtarGrits(object sender, RoutedEventArgs e)
        {
            MadOtarGritsMenu m = new MadOtarGritsMenu();
            Done.Visibility = Visibility.Visible;
            m.DataContext = new MadOtarGrits();
            Container.Child = m;
            item = (IOrderItem)m.DataContext;
        }
        /// <summary> 
        /// Open Dragonborn Waffle Fries list
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void AddDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFriesMenu d = new DragonbornWaffleFriesMenu();
            Done.Visibility = Visibility.Visible;
            d.DataContext = new DragonbornWaffleFries();
            Container.Child = d;
            item = (IOrderItem)d.DataContext;
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            m = new ComboMenu();
            m.DataContext = new Combo();
            Container.Child = m;
            OrderButton.IsEnabled = false;
            Combobool = true;
            AddOrderButton.Visibility = Visibility.Visible;
        }

        private void AddOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(m.DataContext as IOrderItem);
            }
            Container.Child = null;
            Combobool = false;
            OrderButton.IsEnabled = false;
            AddOrderButton.Visibility = Visibility.Hidden;
        }
        public void combobutton()
        {
            OrderButton.IsEnabled = true;
        }
    }
}
