using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;
using System.Collections.Generic;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;


namespace BleakwindBuffet.DataTests.UnitTests.MenuTest
{
    public class ComboTest
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
            public string Description { get; }
        }
        [Fact]
        public void ShouldBeAbleToAddDrink()
        {
            Combo combo = new Combo();
            IOrderItem d = new implementations();
            combo.Drink = d;
            Assert.Equal(d, combo.Drink);
        }
        [Fact]
        public void ShouldBeAbleToAddEntree()
        {
            Combo combo = new Combo();
            IOrderItem e = new implementations();
            combo.Entree = e;
            Assert.Equal(e, combo.Entree);
        }

        [Fact]
        public void ShouldBeAbleToAddSide()
        {
            Combo combo = new Combo();
            IOrderItem s = new implementations();
            combo.Side = s;
            Assert.Equal(s, combo.Side);
        }
        [Theory]
        [InlineData(1.11, 2.22, 3.33, 5.66)]
        [InlineData(1.11, 0, 3.31, 3.42)]
        [InlineData(13.11, 52.22, 23.33, 87.66)]
        public void ShouldBeAbleToAddPricewithDiscount(double price1, double price2, double price3, double total)
        {
            Combo combo = new Combo();
            IOrderItem d = new implementations() { Price = price1 };
            IOrderItem e = new implementations() { Price = price2 };
            IOrderItem s = new implementations() { Price = price3 };
            combo.Side = s;
            combo.Drink = d;
            combo.Entree = e;
            Assert.Equal(total, combo.Price);
        }
        [Theory]
        [InlineData(1.11, 3.31, 3.42)]
        [InlineData(13.11, 23.33, 35.44)]
        public void ShouldBeAbleToAddPricewithDiscountitemMiss(double price1, double price2, double total)
        {
            Combo combo = new Combo();
            IOrderItem d = new implementations() { Price = price1 };
            IOrderItem e = new implementations() { Price = price2 };
            combo.Drink = d;
            combo.Entree = e;
            Assert.Equal(total, combo.Price);
        }
        [Theory]
        [InlineData(451, 523, 132, 1106)]
        [InlineData(634, 126, 365, 1125)]
        public void ShouldBeAbleToAddCalories(uint Calories1, uint Calories2, uint Calories3, double total)
        {
            Combo combo = new Combo();
            IOrderItem s = new implementations() { Calories = Calories1 };
            IOrderItem e = new implementations() { Calories = Calories2 };
            IOrderItem d = new implementations() { Calories = Calories3 };
            combo.Drink = d;
            combo.Entree = e;
            combo.Side = s;
            Assert.Equal(total, combo.Calories);
        }
        [Theory]
        [InlineData(111, 331, 442)]
        [InlineData(311, 333, 644)]
        public void ShouldBeAbleToAddCaloriesitemMiss(uint Calories1, uint Calories2, double total)
        {
            Combo combo = new Combo();
            IOrderItem s = new implementations() { Calories = Calories1 };
            IOrderItem e = new implementations() { Calories = Calories2 };
            combo.Side = s;
            combo.Entree = e;
            Assert.Equal(total, combo.Calories);
        }
        [Theory]
        [InlineData("fir", "sec", "das", "dsa", "asd", "fwe")]
        public void ShouldBeAbleToAddSpecialInstructions(string Spe1, string Spe2, string Spe3, string Spe4, string Spe5, string Spe6)
        {
            Combo combo = new Combo();
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            list1.Add(Spe1);
            list1.Add(Spe2);
            list2.Add(Spe3);
            list2.Add(Spe4);
            list3.Add(Spe5);
            list3.Add(Spe6);
            IOrderItem s = new implementations() { SpecialInstructions = list1 };
            IOrderItem e = new implementations() { SpecialInstructions = list2 };
            IOrderItem d = new implementations() { SpecialInstructions = list3 };
            combo.Side = s;
            combo.Entree = e;
            combo.Drink = d;

            Assert.Contains(Spe1, combo.SpecialInstructions);
            Assert.Contains(Spe2, combo.SpecialInstructions);
            Assert.Contains(Spe3, combo.SpecialInstructions);
            Assert.Contains(Spe4, combo.SpecialInstructions);
            Assert.Contains(Spe5, combo.SpecialInstructions);
            Assert.Contains(Spe6, combo.SpecialInstructions);
            Assert.Contains("Implementations", combo.SpecialInstructions);
        }

        [Theory]
        [InlineData("fir", "sec", "das", "dsa")]
        public void ShouldBeAbleToAddSpecialInstructionsMissItem(string Spe1, string Spe2, string Spe3, string Spe4)
        {
            Combo combo = new Combo();
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            list1.Add(Spe1);
            list1.Add(Spe2);
            list2.Add(Spe3);
            list2.Add(Spe4);
            IOrderItem s = new implementations() { SpecialInstructions = list1 };
            IOrderItem d = new implementations() { SpecialInstructions = list2 };
            combo.Side = s;
            combo.Drink = d;

            Assert.Contains(Spe1, combo.SpecialInstructions);
            Assert.Contains(Spe2, combo.SpecialInstructions);
            Assert.Contains(Spe3, combo.SpecialInstructions);
            Assert.Contains(Spe4, combo.SpecialInstructions);
            Assert.Contains("Implementations", combo.SpecialInstructions);
        }
        [Fact]
        public void ChangingNotifiesProperty()
        {
            Combo combo = new Combo();
            IOrderItem s = new implementations();
            IOrderItem e = new implementations();
            IOrderItem d = new implementations();
            Assert.PropertyChanged(combo, "Price", () =>
             {
                 combo.Drink = d;
             });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink = d;
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Drink = d;
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Entree = e;
            });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Entree = e;
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Entree = e;
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side = s;
            });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = s;
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Side = s;
            });
        }
    }
}
