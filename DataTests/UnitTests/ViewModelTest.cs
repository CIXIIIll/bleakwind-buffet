using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;
using System.Collections.Generic;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;


namespace BleakwindBuffet.DataTests
{
    public class ViewModelTest
    {
        public class implementations : IOrderItem
        {
            public double Price { get; set; }
            public uint Calories { get; set; }
            public List<string> SpecialInstructions { get; set; }
            public override string ToString()
            {
                return "Implementations";
            }
        }
        [Fact]
        public void ShouldBeAbleToAddPenniesFromCustomer()
        {
            ViewModelClass view = new ViewModelClass(new Order());
            Assert.PropertyChanged(view, "Pennies", () =>
            {
                view.Pennies = 1;
            });
            Assert.Equal(0.01, view.TotalPay);
        }
        [Fact]
        public void ShouldBeAbleToAddQuartersFromCustomer()
        {
            ViewModelClass view = new ViewModelClass(new Order());
            Assert.PropertyChanged(view, "Quarters", () =>
            {
                view.Quarters = 1;
            });
            Assert.Equal(0.25, view.TotalPay);
        }
        [Fact]
        public void ShouldBeAbleToAddDollarsFromCustomer()
        {
            ViewModelClass view = new ViewModelClass(new Order());
            Assert.PropertyChanged(view, "Dollars", () =>
            {
                view.Dollars = 1;
            });
            Assert.Equal(1, view.TotalPay);
        }
        [Fact]
        public void ShouldBeAbleToAddFivesFromCustomer()
        {
            ViewModelClass view = new ViewModelClass(new Order());
            Assert.PropertyChanged(view, "Fives", () =>
            {
                view.Fives = 1;
            });
            Assert.Equal(5, view.TotalPay);
        }
        [Fact]
        public void ShouldBeAbleToAddTwentiesFromCustomer()
        {
            ViewModelClass view = new ViewModelClass(new Order());
            Assert.PropertyChanged(view, "Twenties", () =>
            {
                view.Twenties = 1;
            });
            Assert.Equal(20, view.TotalPay);
        }
        [Fact]
        public void ShouldBeAbleToAddHundredsFromCustomer()
        {
            ViewModelClass view = new ViewModelClass(new Order());
            Assert.PropertyChanged(view, "Hundreds", () =>
            {
                view.Hundreds = 1;
            });
            Assert.Equal(100, view.TotalPay);
        }
        [Theory]
        [InlineData(5.0,15.0,2, 0)]
        public void ShouldBeAbleToCalculateChangedtoCustomer(double price1, double price2, int bill, int coin)
        {
            Order order = new Order();
            ViewModelClass view = new ViewModelClass(order);
            order.Add(new implementations() { Price = price1 });
            order.Add(new implementations() { Price = price2 });
            view.Twenties = 2;
            view.GetChanged();
            Assert.Equal(bill, view.Bones);
        }
    }
}
