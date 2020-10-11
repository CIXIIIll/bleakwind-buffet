using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyPropertyChanged, INotifyCollectionChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private List<IOrderItem> orderItems = new List<IOrderItem>();

        private static uint nextOrderNumber = 1;

        public IEnumerable<IOrderItem> OrderItems { 
            get 
            { 
                return orderItems.ToArray(); 
            } 
        }

        public uint NextOrderNumber
        {
            get { return nextOrderNumber++; }
        }
        public double SalesTaxRate { get; set; } = 0.12;

        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (var item in orderItems)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        public double Tax
        {
            get
            {
                double tax = 0;
                tax = Subtotal * SalesTaxRate;
                return tax;
            }
        }
        public double Total
        {
            get
            {
                double total = 0;
                total = Tax + Subtotal;
                return total;
            }
        }
        public uint Calories
        {
            get
            {
                uint cal = 0;
                foreach(var item in orderItems)
                {
                    cal += item.Calories;
                }
                return cal;
            }
        }
        public void Add(IOrderItem item)
        {
            orderItems.Add(item);
            if(item is INotifyPropertyChanged change)
            {
                change.PropertyChanged += PropretyChangeListener;
            }
            CollectionChanged += CollectionChangeListener;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("orderItems"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }
        public void Remove(IOrderItem item)
        {
            orderItems.Remove(item);
            if (item is INotifyPropertyChanged change)
            {
                change.PropertyChanged -= PropretyChangeListener;
            }
            CollectionChanged -= CollectionChangeListener;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("orderItems"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        void PropretyChangeListener (object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("orderItems"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            if(e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        void CollectionChangeListener (object sender, NotifyCollectionChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }



    }
}
