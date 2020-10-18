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
    /// CashButton.xaml 的交互逻辑
    /// </summary>
    public partial class CashButton : UserControl
    {
        public static DependencyProperty ChangesProperty = DependencyProperty.Register("Changes", typeof(int), typeof(CashButton), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static DependencyProperty CashName = DependencyProperty.Register("Names", typeof(string), typeof(CashButton));
        public static DependencyProperty Currentnumber = DependencyProperty.Register("Current", typeof(int), typeof(CashButton),new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public string Names
        {
            get { return (string)GetValue(CashName); }
            set { SetValue(CashName, value); }  
        }
        public int Current
        {
            get { return (int)GetValue(Currentnumber); }
            set { SetValue(Currentnumber, value); }
        }
        public CashButton()
        {
            InitializeComponent();
        }
        public int Changes
        {
            get { return (int)GetValue(ChangesProperty); }
            set { SetValue(ChangesProperty, value); }
        }
        void HandleClicked(object sender, RoutedEventArgs e)
        {
            
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "Increase":
                        Current += 1;
                        break;
                    case "Decrease":
                        Current -= 1;
                        break;
                }
            }
            e.Handled = true;
            if (Current >= 1)
            {
                Decrease.IsEnabled = true;
            }
            else
            {
                Decrease.IsEnabled = false;

            }
        }
    }
}
