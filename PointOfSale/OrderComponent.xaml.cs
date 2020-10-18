/*
* Author: Haoran An
* Class name: OrderComponent.xaml.cs
* Purpose: Interaction logic for OrderComponent.xaml 
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
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        MenuSelection xy;
        Order current;
        /// <summary>
        /// Constructs a new OrderComponent
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
        }
        /// <summary> 
        /// Open a new order
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void Neworder_Click(object sender, RoutedEventArgs e)
        {
            current = new Order();
            DataContext = current;
            xy = new MenuSelection();
            contanerBorder.Child = xy;
            Neworder.Visibility = Visibility.Hidden;
        }
        /// <summary> 
        /// Cancel the current order
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        public void FinishOrder()
        {
            xy = null;
            contanerBorder.Child = null;
            Neworder.Visibility = Visibility.Visible;
            DataContext = null;
            menuBorder.Child = null;
            menuBorder.DataContext = null;
            ReAddToOrder.Visibility = Visibility.Hidden;
        }
        private void Cancelorder_Click(object sender, RoutedEventArgs e)
        {
            FinishOrder();
        }
        public void BackToOrder()
        {
            DataContext = current;
            contanerBorder.Child = xy;
        }
        private void ListChanged(object sender, SelectionChangedEventArgs e)
        {
            if(sender is ListBox list)
            {
                if(list.SelectedItem is IOrderItem item)
                {
                    if(item is BriarheartBurger)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new BriarheartBurgerMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is DoubleDraugr)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new DoubleDraugrMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is GardenOrcOmelette)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new GardenOrcOmeletteMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is PhillyPoacher)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new PhillyPoacherMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is SmokehouseSkeleton)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new SmokehouseSkeletonMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is ThalmorTriple)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new ThalmorTripleMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is ThugsTBone)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new ThugsTBoneMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is AretinoAppleJuice)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new AretinoAppleJuiceMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is CandlehearthCoffee)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new CandlehearthCoffeeMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is MarkarthMilk)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new MarkarthMilkMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is SailorSoda)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new SailorSodaMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is WarriorWater)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new WarriorWaterMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is DragonbornWaffleFries)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new DragonbornWaffleFriesMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is FriedMiraak)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new FriedMiraakMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is MadOtarGrits)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new MadOtarGritsMenu();
                        menuBorder.DataContext = item;
                    }
                    if (item is VokunSalad)
                    {
                        ReAddToOrder.Visibility = Visibility.Visible;
                        menuBorder.Child = new VokunSaladMenu();
                        menuBorder.DataContext = item;
                    }
                }
            }
        }

        private void ReAddToOrder_Click(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = null;
            menuBorder.DataContext = null;
            ReAddToOrder.Visibility = Visibility.Hidden;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if((sender as Button).DataContext is Combo)
                {
                    xy.Combobool = true;
                    xy.combobutton();
                }
                order.Remove((sender as Button).DataContext as IOrderItem);
            }
        }

        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            PaymentControl payment =new PaymentControl();
            contanerBorder.Child = payment;
        }
    }
}
