/*
* Author: Haoran An
* Class name: OrderComponent.xaml.cs
* Purpose: Interaction logic for OrderComponent.xaml 
*/
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
            xy = new MenuSelection();
            contanerBorder.Child = xy;
            Neworder.Visibility = Visibility.Hidden;
        }
        /// <summary> 
        /// Cancel the current order
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void Cancelorder_Click(object sender, RoutedEventArgs e)
        {
            xy = null;
            contanerBorder.Child = null;
            Neworder.Visibility = Visibility.Visible;
        }
    }
}
