/*
* Author: Haoran An
* Class name: Combo.cs
* Purpose: Interaction logic for PaymentControl.xaml
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
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// PaymentControl.xaml 的交互逻辑
    /// </summary>
    public partial class PaymentControl : UserControl
    {
        public PaymentControl()
        {
            InitializeComponent();
        }

        private void CardButton_Click(object sender, RoutedEventArgs e)
        {
            CardTransactionResult result =CardReader.RunCard((DataContext as Order).Total);
            switch (result)
            {
                case CardTransactionResult.Approved:
                    Recieptprinter printer = new Recieptprinter(DataContext as Order, "Card", new ViewModelClass(DataContext as Order));
                    printer.PrintRecipet();
                    if (this.Parent is Border b)
                    {
                        if (b.Parent is Grid g)
                        {
                            if (g.Parent is OrderComponent order)
                            {
                                order.FinishOrder();
                            }
                        }
                    }
                    break;
                case CardTransactionResult.Declined:
                    MessageBox.Show("Card Declined");
                    break;
                case CardTransactionResult.InsufficientFunds:
                    MessageBox.Show("Less Sufficient Funds");
                    break;
                case CardTransactionResult.IncorrectPin:
                    MessageBox.Show("Incorrect Pin");
                    break;
                case CardTransactionResult.ReadError:
                    MessageBox.Show("Read Error");
                    break;
            }
        }

        private void CashButton_Click(object sender, RoutedEventArgs e)
        {
            BackButton.Visibility = Visibility.Hidden;
            CashButton.Visibility = Visibility.Hidden;
            CardButton.Visibility = Visibility.Hidden;
            CashPayment cash = new CashPayment(DataContext as Order);
            CashPanymentBorder.Child = cash;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Border b)
            {
                if (b.Parent is Grid g)
                {
                    if (g.Parent is OrderComponent order)
                    {
                        order.BackToOrder();
                    }
                }
            }
        }
    }
}
