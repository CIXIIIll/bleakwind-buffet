/*
* Author: Haoran An
* Class name: Combo.cs
* Purpose: Interaction logic for CashPayment.xaml
*/
using BleakwindBuffet.Data;
using RoundRegister;
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
    /// CashPayment.xaml 的交互逻辑
    /// </summary>
    public partial class CashPayment : UserControl
    {
        /// <summary>
        /// current payment
        /// </summary>
        ViewModelClass current;
        /// <summary>
        /// current order
        /// </summary>
        Order order;
        public CashPayment(Order ord)
        {
            InitializeComponent();
            order = ord;
            current = new ViewModelClass(order);
            DataContext = current;
            current.PropertyChanged += HandlePropertyChanged;
        }
        /// <summary>
        /// Event Listeners for amount changed
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (DataContext is ViewModelClass vmc)
            {
                if(vmc.Total <=0)
                {
                    foreach(CashButton cashButton in bills.Children)
                    {
                        cashButton.Increase.IsEnabled = false;
                        CheckOutButton.IsEnabled = true;
                    }
                }
                else
                {
                    foreach (CashButton cashButton in bills.Children)
                    {
                        cashButton.Increase.IsEnabled = true;
                        CheckOutButton.IsEnabled = false;
                    }
                }
            }
        }
        /// <summary>
        /// A click event to check out
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        public void CheckOutButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is ViewModelClass vmc)
            {
                vmc.CheckOut();
            }
            current.PropertyChanged -= HandlePropertyChanged;
            if(this.Parent is Border b)
            {
                if(b.Parent is Grid g)
                {
                    if (g.Parent is PaymentControl order)
                    {
                        if (order.Parent is Border b1)
                        {
                            if (b1.Parent is Grid g1)
                            {
                                if (g1.Parent is OrderComponent order1)
                                {
                                    order1.FinishOrder();
                                }
                            }
                        }
                    }
                }
            }
            Recieptprinter printer = new Recieptprinter(order, "Cash",current);
            printer.PrintRecipet();
        }
        /// <summary>
        /// A click event to back to order
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The events describing the event</param>
        private void BackToOrder_Click(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Border b)
            {
                if (b.Parent is Grid g)
                {
                    if (g.Parent is PaymentControl order)
                    {
                        if (order.Parent is Border b1)
                        {
                            if (b1.Parent is Grid g1)
                            {
                                if (g1.Parent is OrderComponent order1)
                                {
                                    order1.BackToOrder();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
