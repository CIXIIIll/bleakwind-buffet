using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;
using System.Collections.Generic;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTest
{
    public class OrderTestcs
    {
        public class implementations : IOrderItem
        {
            public double Price { get; set; }

            public List<string> SpecialInstructions { get; set; }

            public uint Calories { get; set; }
            public override string ToString()
            {
                return "Implementations";
            }
            public string Description { get; }
        }
        public class implementations2 : IOrderItem
        {
            public double Price { get; set; }

            public List<string> SpecialInstructions { get; set; }

            public uint Calories { get; set; }
            public override string ToString()
            {
                return "Implementations2";
            }
            public string Description { get; }
        }
        [Theory]
        [InlineData(1.11, 3.31, 4.42)]
        [InlineData(13.11, 23.33, 36.44)]
        public void ShouldBeAbleToAddSubtotal(double price1, double price2 , double subtotal)
        {
            Order order = new Order();
            IOrderItem d = new implementations() { Price = price1 };
            IOrderItem e = new implementations() { Price = price2 };
            order.Add(d);
            order.Add(e);
            Assert.Equal(subtotal, order.Subtotal);
        }
        [Theory]
        [InlineData(0.11)]
        [InlineData(0.15)]
        [InlineData(52.15)]
        public void ShouldBeAbleToSetSalesTaxRate(double rate)
        {
            Order order = new Order();
            order.SalesTaxRate = rate;
            Assert.Equal(rate, order.SalesTaxRate);
        }

        [Fact]
        public void ShouldAddOrderNumberAfterNewOrder()
        {
            Order order1 = new Order();
            Assert.Equal((uint)1, order1.NextOrderNumber);

            Order order2 = new Order();
            Assert.Equal((uint)2, order2.NextOrderNumber);

            Order order3 = new Order();
            Assert.Equal((uint)3, order3.NextOrderNumber);
        }
        [Theory]
        [InlineData("orderItems")]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void AddAndRemovePropertyChanged(string Name)
        {
            Order order = new Order();
            IOrderItem d = new implementations();
            Assert.PropertyChanged(order, Name, () => 
            {
                order.Add(d); 
            });
            Assert.PropertyChanged(order, Name, () => 
            { 
                order.Remove(d); 
            });
        }
        [Theory]
        [InlineData(16.21,25.21, 0.12, 4.97)]
        [InlineData(15.11, 23.33, 0.15, 5.77)]
        public void ShouldBeAbleToGetTax(double price1,double price2, double SalesTaxRate, double Tax)
        {
            Order order = new Order();
            IOrderItem d = new implementations() { Price = price1 };
            IOrderItem e = new implementations() { Price = price2 };
            order.Add(d);
            order.Add(e);
            order.SalesTaxRate = SalesTaxRate;
            Assert.Equal(Tax, Math.Round(order.Tax, 2));
        }
        [Theory]
        [InlineData(16.21, 25.21, 0.12, 46.39)]
        [InlineData(13.11, 23.33, 0.15, 41.91)]
        public void ShouldBeAbleToGetTotal(double price1, double price2, double SalesTaxRate, double Total)
        {
            Order order = new Order();
            IOrderItem d = new implementations() { Price = price1 };
            IOrderItem e = new implementations() { Price = price2 };
            order.Add(d);
            order.Add(e);
            order.SalesTaxRate = SalesTaxRate;
            Assert.Equal(Total, Math.Round(order.Total, 2));
        }
    }
}
